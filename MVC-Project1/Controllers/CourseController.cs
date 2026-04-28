using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Project1.Context;
using MVC_Project1.Models;

namespace MVC_Project1.Controllers
{
    public class CourseController : Controller
    {
        private readonly DbAppContext db;

        public CourseController(DbAppContext context)
        {
            this.db = context;
        }
        public IActionResult GetAllCourses()
        {
            var courses = db.Courses.ToList();
            return View(courses);
        }

        public IActionResult GetCourseDetails(int id)
        {
            var crs = db.Courses.FirstOrDefault(c => c.CrsId == id);
            return View(crs);
        }
    
        public IActionResult AddNewCourseForm()
        {
            return View();
        }

        public IActionResult SaveAddNewCourse(Course crs)
        {
            if(ModelState.IsValid)
            {
                db.Courses.Add(crs);
                db.SaveChanges();
                return RedirectToAction("GetAllCourses");
            }
            
            return View("AddNewCourseForm");
        }

        public ActionResult EditCourseForm(int id)
        {
            var crs = db.Courses.FirstOrDefault(c => c.CrsId == id);
            return View(crs);
        }

        public ActionResult SaveEditCourse(Course crs)
        {
            if(crs.Name != null && crs.Description != null)
            {
                var updatedCrs = db.Courses.FirstOrDefault(c => c.CrsId == crs.CrsId);
                updatedCrs.Name = crs.Name;
                updatedCrs.Description = crs.Description;
                db.SaveChanges();
                return RedirectToAction("GetAllCourses");
            }
            
            return View("SaveEditCourse", crs);
        }

        public ActionResult Delete(int id)
        {
            var crs = db.Courses.FirstOrDefault(c => (c.CrsId == id));
            if(crs != null)
            {
                // alert 
                db.Courses.Remove(crs);
                db.SaveChanges();
                return RedirectToAction("GetAllCourses");
            }
            return NotFound();
        }




        public IActionResult IsNameUnique(string Name, int CrsId)
        {
            var course = db.Courses.FirstOrDefault(c => c.Name == Name && c.CrsId != CrsId);

            if (course == null)
                return Json(true);
            else
                return Json(false);
        }



    }
}
