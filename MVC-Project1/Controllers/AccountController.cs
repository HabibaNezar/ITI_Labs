using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC_Project1.Models;
using MVC_Project1.ViewModels;
using System.Threading.Tasks;

namespace MVC_Project1.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInMnager;

       

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInMnager) 
        {
            this.userManager = userManager;
            this.signInMnager = signInMnager;
        }

        public IActionResult Index()
        {
            return View("~/Views/Home/Index.cshtml");
        }


        #region Register
        public IActionResult RegisterForm()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterUserViewModel userFromReq)
        {
            if (ModelState.IsValid)
            {
                // save db
                ApplicationUser user = new ApplicationUser()
                {
                    UserName = userFromReq.UserName,
                    Address = userFromReq.Address,
                    PasswordHash = userFromReq.Password,
                    Email = userFromReq.Email,
                };
                IdentityResult result = await userManager.CreateAsync(user, userFromReq.Password);
                if (result.Succeeded)
                {
                    

                    // create cookie
                    await signInMnager.SignInAsync(user, false);
                    return RedirectToAction("GetAllStudents", "Student");

                }
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            return View("RegisterForm");
        }

        #endregion

        #region Login

        public IActionResult LoginForm()
        {
            return View();
        }

        public async Task<IActionResult> Login(LoginViewModel userReq)
        {
            ApplicationUser userFromDb = await userManager.FindByNameAsync(userReq.UserName);

            if (ModelState.IsValid)
            {
                if(userFromDb != null)
                {
                    bool found = await userManager.CheckPasswordAsync(userFromDb, userReq.Password);
                    if (found)
                    {
                        // create cookie
                        await signInMnager.SignInAsync(userFromDb, userReq.RememberMe);
                        return RedirectToAction("GetAllStudents", "Student");
                    }
                }
                ModelState.AddModelError("", "Invalid Account");
            }
            return View("LoginForm", userReq);
        }

        #endregion

        #region Logout
        public async Task<IActionResult> SignOut()
        {
            await signInMnager.SignOutAsync();
            return RedirectToAction("Index");
        }
        #endregion
    }
}
