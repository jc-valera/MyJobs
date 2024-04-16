using Microsoft.AspNetCore.Mvc;
using Portafolio.Core.Common.Entities;
using Portafolio.Core.Common.Services;

namespace TestSolAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public IEmployeeBLL EmployeeBLL;

        public EmployeeController(IEmployeeBLL employeeBLL)
        {
            EmployeeBLL = employeeBLL;
        }

        [HttpGet("apiStatus")]
        public async Task<ActionResult> GetStatus()
        {
            return Ok();
        }

        [HttpGet("getAllEmployees")]
        public async Task<ActionResult> GetAllEmployees()
        {
            try
            {
                var employees = await EmployeeBLL.GetAllEmployees();

                return Ok(employees);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet("getEmployee/{id}")]
        public async Task<ActionResult> GetEmployee(int id)
        {
            try
            {
                var employee = await EmployeeBLL.GetEmployee(id);

                return Ok(employee);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost("saveEmployee")]
        public async Task<ActionResult> SaveEmployee([FromBody] Employee employee)
        {
            try
            {
                await EmployeeBLL.IsDataValid(employee);

                await EmployeeBLL.SaveEmployee(employee);

                return Ok();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPut("updateEmployee/{id}")]
        public async Task<ActionResult> UpdateEmployee(int id, [FromBody] Employee employee)
        {
            try
            {
                var employeeExist = await EmployeeBLL.GetEmployee(id);

                employeeExist.Name = employee.Name;
                employeeExist.FirstSurname = employee.FirstSurname;
                employeeExist.SecondSurname = employee.SecondSurname;
                employeeExist.Area = employee.Area;
                employeeExist.BirthDate = employee.BirthDate;
                employeeExist.Salary = employee.Salary;

                await EmployeeBLL.UpdateEmployee(employeeExist);

                return Ok();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpDelete("deleteEmployee/{id}")]
        public async Task<ActionResult> DeleteEmployee(int id)
        {
            try
            {
                await EmployeeBLL.DeleteEmpoye(id);

                return Ok();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
