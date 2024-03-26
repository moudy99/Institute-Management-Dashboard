using LAP.Authentication;
using LAP.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LAP.Controllers
{

    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RolesCreation rolesCreation;

        public HomeController(ILogger<HomeController> logger, RolesCreation rolesCreation)
        {
            _logger = logger;
            this.rolesCreation = rolesCreation;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Landing() { return View(); }

        public async Task<IActionResult> CreateRole()
        {
            string[] roles = new string[] { "Trainee", "Instructor", "Admin" };

            foreach (string role in roles)
            {
                await rolesCreation.CreateRoleAsync(role);
            }
            return RedirectToAction("Landing");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
