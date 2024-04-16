using Portafolio.Core.Common.Entities;

namespace Portafolio.Core.Common.Services
{
    public interface IEmployeeBLL
    {
        Task<IEnumerable<Employee>> GetAllEmployees();

        Task<Employee> GetEmployee(int id);

        Task SaveEmployee(Employee employee);

        Task DeleteEmpoye(int id);

        Task UpdateEmployee(Employee employee);
        
        /**/
        Task IsDataValid(Employee employee);
    }
}
