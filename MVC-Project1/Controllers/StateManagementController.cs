using Microsoft.AspNetCore.Mvc;

namespace MVC_Project1.Controllers
{
    public class StateManagementController : Controller
    {
        // sesstion => store data on the server => secure
        // set
        public IActionResult SetSession(int age, string name)
        {
            HttpContext.Session.SetString("Name", name);
            HttpContext.Session.SetInt32("Age", age);
            return Content("session saved success");
        }
        // get
        public IActionResult GetSession()
        {
            string? n = HttpContext.Session.GetString("Name");
            int? a = HttpContext.Session.GetInt32("Age");
            return Content($"Name = {n} Age = {a}");
        }
    }
}
