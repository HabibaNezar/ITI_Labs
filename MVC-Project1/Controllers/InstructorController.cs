using Microsoft.AspNetCore.Mvc;
using MVC_Project1.Context;
using MVC_Project1.Models;

namespace MVC_Project1.Controllers
{
    public class InstructorController : Controller
    {
        private readonly DbAppContext db;

        public InstructorController(DbAppContext context)
        {
            this.db = context;
        }
        public IActionResult GetAllInstructors()
        {
            var Instructors = db.Instructors.ToList();
            return View(Instructors);
        }

        public IActionResult GetInstructorDetails(int id)
        {
            var ins = db.Instructors.FirstOrDefault(c => c.InsId == id);
            return View(ins);
        }

        public IActionResult AddNewInstructorForm()
        {
            return View();
        }

        public IActionResult SaveAddNewInstructor(Instructor ins)
        {
            if (ModelState.IsValid)
            {
                db.Instructors.Add(ins);
                db.SaveChanges();
                return RedirectToAction("GetAllInstructors");
            }

            return View("SaveAddNewInstructor");
        }

        public ActionResult EditInstructorForm(int id)
        {
            var crs = db.Instructors.FirstOrDefault(c => c.InsId == id);
            return View(crs);
        }

        public ActionResult SaveEditInstructor(Instructor ins)
        {
            if (ModelState.IsValid)
            {
                var updatedIns = db.Instructors.FirstOrDefault(c => c.InsId == ins.InsId);
                updatedIns.InsName = ins.InsName ;
                updatedIns.Salary = ins.Salary;
                updatedIns.Age = ins.Age;
                updatedIns.Address = ins.Address;
                updatedIns.Degree = ins.Degree;
                updatedIns.Email = ins.Email;

                db.SaveChanges();
                return RedirectToAction("GetAllInstructors");
            }

            return View("SaveEditCourse", ins);
        }

        public ActionResult Delete(int id)
        {
            var ins = db.Instructors.FirstOrDefault(c => (c.InsId == id));
            if (ins != null)
            {
                // alert 
                db.Instructors.Remove(ins);
                db.SaveChanges();
                return RedirectToAction("GetAllInstructors");
            }
            return NotFound();
        }




       
    }
}
