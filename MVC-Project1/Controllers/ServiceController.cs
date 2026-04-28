using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace MVC_Project1.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Welcome()
        {
            if (User.Identity.IsAuthenticated)
            {
                Claim idClaim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);
                string id = idClaim.Value;
                return Content($"Welcome {User.Identity.Name}");

            }
            return Content("Welcome geust");
        }
    }
}
