using Microsoft.AspNetCore.Mvc;
using TestSol.BLL;
using TestSol.Models.Entities;

namespace TestSol.Controllers
{
    public class EmployeesController : Controller
    {
        public RequestBLL RequestBLL;
        public EmployeesController()
        {
            RequestBLL = new RequestBLL();
        }

        public async Task<ActionResult> Home()
        {
            try
            {
                await RequestBLL.GetStatusService();

                return View();
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View("Error");
            }
        }

        public async Task<ActionResult> Index()
        {
            var employees = new List<Employee>();

            try
            {
                employees = await RequestBLL.GetAllEmployees();
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View("Error");
            }

            return View(employees);
        }

        public async Task<ActionResult> Details(int id)
        {
            var employee = new Employee();

            try
            {
                employee = await RequestBLL.GetEmployee(id);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View("Error");
            }

            return View(employee);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Employee employee)
        {
            try
            {
                await RequestBLL.CreateEployee(employee);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View("Error");
            }
        }

        public async Task<ActionResult> Edit(int id)
        {
            try
            {
                var employee = new Employee();
                employee = await RequestBLL.GetEmployee(id);

                return View(employee);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View("Error");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Employee employee)
        {
            try
            {
                await RequestBLL.UpdateEmployee(id, employee);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View("Error");
            }
        }

        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var employee = new Employee();
                employee = await RequestBLL.GetEmployee(id);

                return View(employee);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View("Error");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, Employee employee)
        {
            try
            {
                await RequestBLL.DeleteEmployee(id);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View("Error");
            }
        }
    }
}
