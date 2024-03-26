using LAP.Models;
using Microsoft.AspNetCore.Mvc;

namespace LAP.Controllers
{
    public class xController : Controller
    {
        public IActionResult x([Bind(include: "ID , Name")] Trainee t)
        {


            return View();
        }
    }
}
