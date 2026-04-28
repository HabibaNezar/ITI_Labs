using Microsoft.AspNetCore.Mvc;
using MVC_Project1.Context;
using MVC_Project1.Models;

namespace MVC_Project1.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly DbAppContext db;

        public DepartmentController(DbAppContext context)
        {
            this.db = context;
        }
        public IActionResult GetAllDepartments()
        {
            var depts = db.Departments.ToList();
            return View(depts);
        }

        public IActionResult GetDepartmentDetails(int id)
        {
            var dept = db.Departments.FirstOrDefault(d => d.DeptId == id);
            return View(dept);
        }

        public IActionResult AddNewDepartmentForm()
        {
            return View();
        }

        public IActionResult SaveAddNewDepartment(Department dept)
        {
            if (dept.DeptName != null && dept.Loc != null && dept.Phone != null)
            {
                db.Departments.Add(dept);
                db.SaveChanges();
                return RedirectToAction("GetAllDepartments");
            }

            return View("SaveAddNewDepartment");
        }

        public ActionResult EditDepartmentForm(int id)
        {
            var dept = db.Departments.FirstOrDefault(d => d.DeptId == id);
            return View(dept);
        }

        public ActionResult SaveEditDepartment(Department dept)
        {
            if (dept.DeptName != null && dept.Loc != null && dept.Phone != null)
            {
                var updatedDept = db.Departments.FirstOrDefault(d => d.DeptId == dept.DeptId);
                updatedDept.DeptName = dept.DeptName;
                updatedDept.Phone = dept.Phone;
                updatedDept.Loc = dept.Loc;
                db.SaveChanges();
                return RedirectToAction("GetAllDepartments");
            }

            return View("SaveEditDepartment", dept);
        }

        public ActionResult Delete(int id)
        {
            var dept = db.Departments.FirstOrDefault(d => (d.DeptId == id));
            if (dept != null)
            {
                // alert 
                db.Departments.Remove(dept);
                db.SaveChanges();
                return RedirectToAction("GetAllDepartments");
            }
            return NotFound();
        }
    }
}
