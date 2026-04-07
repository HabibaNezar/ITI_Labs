using ITI_EF_Day3.Context;
using ITI_EF_Day3.Models;
using Microsoft.EntityFrameworkCore;

namespace ITI_EF_Day3.Services
{
    internal class StudentService
    {
        ITIDbContext db = new ITIDbContext();
        public int CreateStudent(string fname, string lname, string address, int age, int deptid, int stdsuper)
        {
            Student std = new Student
            {
                StFname = fname,
                StLname = lname,
                StAddress = address,
                StAge = age,
                DeptId = deptid,
                StSuper = stdsuper
            };
            db.Students.Add(std);
            db.SaveChanges();
            Console.WriteLine($"Student {std.StFname} {std.StLname} Added successfully!");
            return std.StId;
        }

        public void ReadAllStudents()
        {
            var Std = db.Students.Include(s => s.Dept).ToList();
            foreach (var std in Std)
            {
                Console.WriteLine($"Std {std.StFname} {std.StLname} deptName {std.Dept!.DeptName}");
            }
        }

        public void UpdateStudentAge(int id, int newAge)
        {
            var std = db.Students.Find(id);
            if (std != null)
            {
                std.StAge = newAge;
                db.SaveChanges();
                Console.WriteLine($"student {std.StFname} {std.StLname} Age updated to {std.StAge}");
            }
        }

        public void DeleteStudent(int id)
        {
            var std = db.Students.Find(id);
            if (std != null)
            {
                db.Students.Remove(std);
                db.SaveChanges();
                Console.WriteLine($"student {std.StFname} {std.StLname} Deleted successfully");
            }
        }
    }
}
