using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Text;
using TestSolWFA.Model.Entities;

namespace TestSolWFA.BLL
{
    public class RequestBLL
    {
        public string ServiceUrlApi { get; set; }

        public async Task GetUrlApi()
        {
            var config = new ConfigurationBuilder().AddJsonFile("config.json").Build();
            ServiceUrlApi = config.GetValue<string>("AppConfig:TestSolApi");
        }

        public async Task GetServiceStatus()
        {
            await GetUrlApi();
            var url = $"{ServiceUrlApi}/apiStatus";

            HttpResponseMessage response;

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();

                response = await client.GetAsync(url).ConfigureAwait(false);
            }

            if (!response.IsSuccessStatusCode)
                throw new ApplicationException("Lo sentimos pero el servicio no se encutra disponible, intentelo más tarde.");

        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            var employees = new List<Employee>();

            try
            {
                await GetUrlApi();
                var url = $"{ServiceUrlApi}/getAllEmployees";

                HttpResponseMessage response;

                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Clear();

                    response = await client.GetAsync(url).ConfigureAwait(false);

                    employees = JsonConvert.DeserializeObject<List<Employee>>(await response.Content.ReadAsStringAsync().ConfigureAwait(false));
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Se genero un error al obtener la lista de los empleados, intentelo más tarde.");
            }

            return employees;
        }

        public async Task<Employee> GetEmployee(int id)
        {
            var employee = new Employee();

            try
            {
                await GetUrlApi();
                var url = $"{ServiceUrlApi}/getEmployee/{id}";

                HttpResponseMessage response;

                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Clear();

                    response = await client.GetAsync(url).ConfigureAwait(false);

                    employee = JsonConvert.DeserializeObject<Employee>(await response.Content.ReadAsStringAsync().ConfigureAwait(false));
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return employee;
        }

        public async Task CreateEployee(Employee employee)
        {
            await GetUrlApi();

            var url = $"{ServiceUrlApi}/saveEmployee";

            HttpResponseMessage response;

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();

                var content = new StringContent(JsonConvert.SerializeObject(employee), Encoding.UTF8, "application/json");

                response = await client.PostAsync(url, content).ConfigureAwait(false);
            }

            if (!response.IsSuccessStatusCode)
                throw new ApplicationException();
        }

        public async Task UpdateEmployee(int id, Employee employee)
        {
            await GetUrlApi();
            var url = $"{ServiceUrlApi}/updateEmployee/{id}";

            HttpResponseMessage response;

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();

                var content = new StringContent(JsonConvert.SerializeObject(employee), Encoding.UTF8, "application/json");

                response = await client.PutAsync(url, content).ConfigureAwait(false);
            }

            if (!response.IsSuccessStatusCode)
                throw new ApplicationException();
        }

        public async Task DeleteEmployee(int id)
        {
            await GetUrlApi();
            var url = $"{ServiceUrlApi}/deleteEmployee/{id}";

            HttpResponseMessage response;

            using (var clint = new HttpClient())
            {
                clint.DefaultRequestHeaders.Clear();

                response = await clint.DeleteAsync(url).ConfigureAwait(false);
            }

            if (!response.IsSuccessStatusCode)
                throw new ApplicationException();
        }
    }
}
