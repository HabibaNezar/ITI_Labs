using ITI_EF.Context;
using ITI_EF.Models;
using Microsoft.EntityFrameworkCore;

namespace ITI_EF
{
    internal class Program
    {
        #region Department CRUD
        static int CreateDepartment(string name, string desc, string location)
        {
            using var context = new AppDbContext();
            var dept = new Department { Dept_Name = name, Dept_Desc = desc, Dept_Location = location };
            context.Departments.Add(dept);
            context.SaveChanges();
            Console.WriteLine($"Added Department: {dept.Dept_Name}");
            return dept.Dept_Id;
        }

        static void ReadDepartments()
        {
            using var context = new AppDbContext();
            var depts = context.Departments.ToList();
            foreach (var d in depts)
            {
                Console.WriteLine($"Dept ID: {d.Dept_Id}, Name: {d.Dept_Name}, Location: {d.Dept_Location}");
            }
        }

        static void UpdateDepartmentLocation(int id, string newLocation)
        {
            using var context = new AppDbContext();
            var dept = context.Departments.Find(id);
            if (dept != null)
            {
                dept.Dept_Location = newLocation;
                context.SaveChanges();
                Console.WriteLine($"Updated Department {id} location to {newLocation}");
            }
        }

        static void DeleteDepartment(int id)
        {
            using var context = new AppDbContext();
            var dept = context.Departments.Find(id);
            if (dept != null)
            {
                context.Departments.Remove(dept);
                context.SaveChanges();
                Console.WriteLine($"Deleted Department {id}");
            }
        }
        #endregion

        #region Course CRUD
        static int CreateCourse(string name, int duration)
        {
            using var context = new AppDbContext();
            var course = new Course { Crs_Name = name, Crs_Duration = duration };
            context.Courses.Add(course);
            context.SaveChanges();
            Console.WriteLine($"Added Course: {course.Crs_Name}");
            return course.Crs_Id;
        }

        static void ReadCourses()
        {
            using var context = new AppDbContext();
            var courses = context.Courses.ToList();
            foreach (var c in courses)
            {
                Console.WriteLine($"Course ID: {c.Crs_Id}, Name: {c.Crs_Name}, Duration: {c.Crs_Duration} hours");
            }
        }

        static void UpdateCourseDuration(int id, int newDuration)
        {
            using var context = new AppDbContext();
            var course = context.Courses.Find(id);
            if (course != null)
            {
                course.Crs_Duration = newDuration;
                context.SaveChanges();
                Console.WriteLine($"Updated Course {id} duration to {newDuration} hours");
            }
        }
        #endregion

        #region Student CRUD
        static int CreateStudent(string fName, string lName, string address, int age, int deptId)
        {
            using var context = new AppDbContext();
            var student = new Student
            {
                St_Fname = fName,
                St_Lname = lName,
                St_Address = address,
                St_Age = age,
                Dept_Id = deptId // Assigning the student to a department
            };
            context.Students.Add(student);
            context.SaveChanges();
            Console.WriteLine($"Added Student: {student.St_Fname} {student.St_Lname}");
            return student.St_Id;
        }

        static void ReadStudents()
        {
            using var context = new AppDbContext();
            // Using Include() to eagerly load the Department navigation property
            var students = context.Students.Include(s => s.Department).ToList();
            foreach (var s in students)
            {
                string deptName = s.Department != null ? s.Department.Dept_Name : "No Dept";
                Console.WriteLine($"Student ID: {s.St_Id}, Name: {s.St_Fname} {s.St_Lname}, Dept: {deptName}");
            }
        }

        static void UpdateStudentAge(int id, int newAge)
        {
            using var context = new AppDbContext();
            var student = context.Students.Find(id);
            if (student != null)
            {
                student.St_Age = newAge;
                context.SaveChanges();
                Console.WriteLine($"Updated Student {id} age to {newAge}");
            }
        }

        static void DeleteStudent(int id)
        {
            using var context = new AppDbContext();
            var student = context.Students.Find(id);
            if (student != null)
            {
                context.Students.Remove(student);
                context.SaveChanges();
                Console.WriteLine($"Deleted Student {id}");
            }
        }
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("Starting CRUD Operations...");

            // --- DEPARTMENT CRUD ---
            Console.WriteLine("\n--- Department CRUD ---");
            // Create
            int deptId = CreateDepartment("Open Source", "OS", "tanta");
            // Read
            ReadDepartments();
            // Update
            UpdateDepartmentLocation(deptId, "tanta");
            // Delete (Commented out to keep data for students)
            // DeleteDepartment(deptId);


            // --- COURSE CRUD ---
            Console.WriteLine("\n--- Course CRUD ---");
            // Create
            int courseId = CreateCourse("C#", 60);
            // Read
            ReadCourses();
            // Update
            UpdateCourseDuration(courseId, 80);


            // --- STUDENT CRUD ---
            Console.WriteLine("\n--- Student CRUD ---");
            // Create
            int studentId = CreateStudent("Ahmed", "Ali", "Cairo", 24, deptId);
            // Read
            ReadStudents();
            // Update
            UpdateStudentAge(studentId, 25);
            // Delete
            //DeleteStudent(studentId);

            Console.WriteLine("\nOperations Completed!");
        }

       
    }
}
