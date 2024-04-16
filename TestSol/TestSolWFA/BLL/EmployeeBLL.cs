using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSolWFA.Model.Entities;

namespace TestSolWFA.BLL
{
    public class EmployeeBLL
    {
        public RequestBLL RequestBLL;

        public EmployeeBLL()
        {
            RequestBLL = new RequestBLL();
        }

        public async Task GetServiceStatus()
        {
            try
            {
                await RequestBLL.GetServiceStatus();
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            var employees = new List<Employee>();

            try
            {
                employees = await RequestBLL.GetAllEmployees();
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }

            return employees;
        }

        public async Task<Employee> GetEmployee(int id)
        {
            var employee = new Employee();

            try
            {
                employee = await RequestBLL.GetEmployee(id);
            }
            catch (Exception)
            {
                throw;
            }

            return employee;
        }

        public async void CreateEployee(Employee employee)
        {
            try
            {
                await RequestBLL.CreateEployee(employee);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async void UpdateEmployee(int id, Employee employee)
        {
            try
            {
                await RequestBLL.UpdateEmployee(id, employee);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task DeleteEmployee(int id)
        {
            try
            {
                await RequestBLL.DeleteEmployee(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
