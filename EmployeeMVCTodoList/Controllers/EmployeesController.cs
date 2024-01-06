using Microsoft.AspNetCore.Mvc;

namespace EmployeeMVCTodoList.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
