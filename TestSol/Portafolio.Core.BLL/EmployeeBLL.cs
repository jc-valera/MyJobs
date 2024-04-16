using Microsoft.EntityFrameworkCore;
using Portafolio.Core.Common.Entities;
using Portafolio.Core.Common.Services;
using Portafolio.Core.DAL;
using System.Text.RegularExpressions;

namespace Portafolio.Core.BLL
{
    public class EmployeeBLL : IEmployeeBLL
    {
        private EmployeeDAL EmployeeDAL;

        public EmployeeBLL(EmployeeDAL employeeDAL)
        {
            EmployeeDAL = employeeDAL;
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            var employees = new List<Employee>();

            try
            {
                employees = await EmployeeDAL.Employees.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Se produjo un error al obtener información  de los empleados, consulte a soporte técnico.");
            }

            return employees;
        }

        public async Task<Employee> GetEmployee(int id)
        {
            var employee = new Employee();

            try
            {
                employee = await EmployeeDAL.Employees.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Se produjo un error al obtener información  del empleado, consulte a soporte técnico.");
            }

            return employee;
        }

        public async Task SaveEmployee(Employee employee)
        {
            try
            {
                EmployeeDAL.Employees.Add(employee);

                await EmployeeDAL.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Se produjo un error al guardar la información  del empleado, consulte a soporte técnico.");
            }
        }

        public async Task DeleteEmpoye(int id)
        {
            try
            {
                var employee = await EmployeeDAL.Employees.FindAsync(id);

                EmployeeDAL.Employees.Remove(employee);

                await EmployeeDAL.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new Exception($"Se produjo un error al eliminar la información  del empleado, consulte a soporte técnico.");
            }
        }


        public async Task UpdateEmployee(Employee employee)
        {
            try
            {
                EmployeeDAL.Entry(employee).State = EntityState.Modified;

                await EmployeeDAL.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new Exception($"Se produjo un error al actualizar la información  del empleado, consulte a soporte técnico.");
            }
        }

        public async Task IsDataValid(Employee employee)
        {
            try
            {
                if (string.IsNullOrEmpty(employee.Name) ||
                string.IsNullOrEmpty(employee.FirstSurname) ||
                string.IsNullOrEmpty(employee.SecondSurname) ||
                string.IsNullOrEmpty(employee.Area))
                {
                    throw new Exception("Todos los campos son requeridos");
                }
                else if (string.IsNullOrEmpty(employee.Salary.ToString()) || Regex.IsMatch(employee.Salary.ToString(), "[^0-9.]"))
                {
                    throw new Exception("El campo salario es requerido y solo se aceptan numeros");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
