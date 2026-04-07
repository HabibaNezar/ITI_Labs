using Microsoft.AspNetCore.Mvc;
using MVC_Day1.Context;

namespace MVC_Day1.Controllers
{
    public class StudentController : Controller
    {
        DbAbbContext db = new DbAbbContext(); 


        public IActionResult Index()
        {
            var studentsList = db.Students.ToList();
            return View("Index", studentsList);
        }

        public IActionResult GetByID(int id)
        {
            var studentModel = db.Students.FirstOrDefault(s => s.Id == id);
            return View("GetStudentById", studentModel);
        }
    }
}
