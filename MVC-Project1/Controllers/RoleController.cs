using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Project1.Models;
using MVC_Project1.ViewModels;
using System.Threading.Tasks;

namespace MVC_Project1.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInMnager;

        public RoleController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInMnager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.signInMnager = signInMnager;
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RoleViewModel roleViewModel)
        {
            if (ModelState.IsValid)
            {
                // save
                IdentityRole identityRole = new IdentityRole();
                identityRole.Name = roleViewModel.Role;
                IdentityResult result = await roleManager.CreateAsync(identityRole);
                if (result.Succeeded)
                {
                    return View("Create");
                }
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            return View("Create", roleViewModel);
        }

        #region Register
        public IActionResult RegisterRoleForm()
        {
            ViewBag.Roles = new SelectList(roleManager.Roles.ToList(), "Name", "Name");
            return View();
        }

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterRoleViewModel userFromReq)
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
                    // add user to Admin Role
                    await userManager.AddToRoleAsync(user, userFromReq.Role);

                    // create cookie
                    await signInMnager.SignInAsync(user, false);
                    return RedirectToAction("GetAllStudents", "Student");

                }
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            ViewBag.Roles = new SelectList(roleManager.Roles.ToList(), "Name", "Name");
            return View("RegisterForm");
        }

        #endregion
    }
}
