using Microsoft.AspNetCore.Mvc;

namespace LAP.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
