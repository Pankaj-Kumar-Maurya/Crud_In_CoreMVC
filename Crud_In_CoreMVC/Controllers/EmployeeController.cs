using Microsoft.AspNetCore.Mvc;

namespace Crud_In_CoreMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
