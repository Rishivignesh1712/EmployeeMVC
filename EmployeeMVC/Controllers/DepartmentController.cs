using Microsoft.AspNetCore.Mvc;

namespace EmployeeMVC.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Postdata()
        {
            return View();
        }
    }
}
