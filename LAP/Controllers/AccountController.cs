using LAP.Authentication;
using LAP.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace LAP.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManger;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public AccountController(UserManager<ApplicationUser> _userManger, SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            userManger = _userManger;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(Register_new_account_viewModel user) // Async always return an Task 
        {
            if (ModelState.IsValid)
            {
                ApplicationUser model = new ApplicationUser();
                model.Email = user.Email;
                model.PasswordHash = user.Password;
                model.UserName = user.UserName;
                model.Address = user.Address;


                ////////////////////////////////////////////////////////////////// Use the this overload constructor ==> to has the password and make validation on the password 
                IdentityResult result = await userManger.CreateAsync(model, model.PasswordHash);

                if (result.Succeeded)
                {
                    /// Add Trainee Role To any one register in the website  (Application USer, Role Name)
                    await userManger.AddToRoleAsync(model, "Trainee");
                    //// List of claims that will send into the Cookie 
                    List<Claim> clamis = new List<Claim>();
                    clamis.Add(new Claim("color", "Red"));

                    /// Save Cookies and login ==> 
                    await signInManager.SignInWithClaimsAsync(model, false, clamis);

                    return RedirectToAction("Index", "trainee");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("Password", error.Description);
                    }
                }
            }
            return View(user);
        }

        public async Task<IActionResult> Login(Login_viewModel user)
        {


            // Populate roles again before returning the view
            ViewBag.Roles = roleManager.Roles;

            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> checkLogin(Login_viewModel user)
        {
            if (ModelState.IsValid == true)
            {
                //1-Check if the userName exist in database 

                ApplicationUser applicationUser = await userManger.FindByNameAsync(user.UserName);

                //2- Check from this record that return from database if the password that enter is right or not
                if (applicationUser != null)
                {
                    bool found = await userManger.CheckPasswordAsync(applicationUser, user.Password);

                    //3- create cookie 
                    if (found)
                    {
                        /// Check User Role ==> 
                        var userRole = await userManger.GetRolesAsync(applicationUser);
                        if (userRole.Contains(user.Role))
                        {

                            //create cookie->
                            await signInManager.SignInAsync(applicationUser, user.RememberMe);

                            /// For Test Get  the ID of the user and add to cookie called Got-user-id ==> User here is the @User that inherit from Controller like this one in the View
                            //var v = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);

                            return RedirectToAction("Landing", "Home");
                        }
                    }
                }
                ModelState.AddModelError("error", "Incorrect user name, password, or role. Please double-check your information");
            }


            ViewBag.Roles = roleManager.Roles;

            return View("Login", user);
        }

        public IActionResult logout()
        {

            signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }

        public async Task<IActionResult> ChangeRoles()
        {
            ApplicationUser newAdmin = await userManger.FindByNameAsync("Moudy");
            ApplicationUser newInstructor = await userManger.FindByNameAsync("Ahmed");

            if (newAdmin != null)
            {
                await userManger.AddToRoleAsync(newAdmin, "Admin");
            }

            if (newInstructor != null)
            {
                await userManger.AddToRoleAsync(newInstructor, "Instructor");
            }
            return RedirectToAction("Landing", "Home");
        }


        private async Task RemoveRole(string username, string roleName)
        {
            // Find user by username
            ApplicationUser user = await userManger.FindByNameAsync(username);

            // Check if the user exists and is in the specified role
            if (user != null && await userManger.IsInRoleAsync(user, roleName))
            {
                await userManger.RemoveFromRoleAsync(user, roleName);
            }
        }

    }
}
