using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Project1.Context;
using MVC_Project1.Models;
using MVC_Project1.Repository;
using MVC_Project1.Services;
using MVC_Project1.ViewModels;
using System.Threading.Tasks;

namespace MVC_Project1.Controllers
{
    public class StudentController : Controller
    {
        // DbAppContext db = new DbAppContext();
        
        IStudentRepository stdRepo;
        IDepartmentRepository deptRepo;

        public StudentController(IStudentRepository stdRepository, IDepartmentRepository deptRepository)
        {
            this.stdRepo = stdRepository;
            this.deptRepo = deptRepository;
        }
        [Authorize]
        public IActionResult GetAllStudents()
        {
            
            return View(stdRepo.GetAll("Dept"));
        }

        public IActionResult GetStudentDetails(int id)
        {
            var std = stdRepo.GetById(id, "Dept");

            if (std == null)
                return NotFound();

            // ✅ now everything comes from the same repository (same db instance)
            StudentViewModel stdVM = new StudentViewModel
            {
                Ssn = std.Ssn,
                Name = std.Name,
                Email = std.Email,
                Phone = std.Phone,
                Address = std.Address,
                Image = std.Image,
                DeptId = std.DeptId,
                DeptName = std.Dept?.DeptName,   // ✅ ?. just in case
                StudentCourses = stdRepo.GetStudentCourses(std.Ssn)  // ✅ same db
            };

            return View(stdVM);
        }

        public IActionResult AddNewStudentForm()
        {

            var stdViewModel = new StudentViewModel();

            stdViewModel.Departments = deptRepo.GetAll();

            return View(stdViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> SaveNewStudent(StudentViewModel stdMV, IFormFile Image)
        {
            if (Image == null || Image.Length == 0)
            {
                ModelState.AddModelError("Image", "please upload image");
            }

            if (ModelState.IsValid)
            {
                string fileName = await DocumentSettings.UploadFileAsync(Image, "images");
                

                Student newStd = new Student
                {
                    
                    Name = stdMV.Name,
                    Address = stdMV.Address,
                    Phone = stdMV.Phone,
                    Email = stdMV.Email,
                    Image = fileName,
                    DeptId = stdMV.DeptId
                };

                stdRepo.add(newStd);
                stdRepo.save();

                TempData["success"] = "Student added successfully!";

                return RedirectToAction("GetAllStudents");
            }

            
            stdMV.Departments = deptRepo.GetAll();
            return View("AddNewStudentForm", stdMV);
        }

        // ✅ Fix — check null FIRST
        public IActionResult UpdateStudentForm(int id)
        {
            var std = stdRepo.GetById(id);

            if (std == null)         // ✅ check before touching std
                return NotFound();

            StudentViewModel stdVM = new StudentViewModel
            {
                Ssn = std.Ssn,
                Name = std.Name,
                Address = std.Address,
                Phone = std.Phone,
                Email = std.Email,
                Image = std.Image,
                Departments = deptRepo.GetAll()
            };

            return View(stdVM);
        }
        [HttpPost]
        public async Task<IActionResult> SaveUpdateStudent(StudentViewModel stdReq, IFormFile Image)
        {
            // ✅ Fix — check null first
            var stdDb = stdRepo.GetById(stdReq.Ssn);

            if (stdDb == null)
                return NotFound();

            if (Image != null && Image.Length > 0)
            {
                stdDb.Image = await DocumentSettings.UploadFileAsync(Image, "images");
            }

            // now you can safely remove the inner if (stdDb != null) check — it's redundant
            if (stdReq.Name != null && stdReq.Address != null && stdReq.Phone != null && stdReq.Email != null)
            {
                stdDb.Name = stdReq.Name;
                stdDb.Address = stdReq.Address;
                stdDb.Phone = stdReq.Phone;
                stdDb.Email = stdReq.Email;
                stdDb.DeptId = stdReq.DeptId;
                stdRepo.update(stdDb);
                stdRepo.save();

                return RedirectToAction("GetAllStudents");
            }

            stdReq.Departments = deptRepo.GetAll();
            return View("UpdateStudentForm", stdReq);

        }


        public ActionResult Delete(int id)
        {
            var std = stdRepo.GetById(id);
            if (std != null)
            {
                stdRepo.delete(id);
                stdRepo.save();
                return RedirectToAction("GetAllStudents");
            }
            return NotFound();
        }



       



    }
}
