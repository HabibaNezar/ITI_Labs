using Microsoft.AspNetCore.Mvc;

namespace MVC_Project1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
