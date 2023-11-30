using Microsoft.AspNetCore.Mvc;

namespace EmployeeMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Postdata()
        {
            return View();
        }
    }
}
