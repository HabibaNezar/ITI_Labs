using Entity_Framework_Labs.Context;

namespace Entity_Framework_Labs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Context
            AppDbContext db = new AppDbContext();
            #endregion

            #region db Creation Strategy
            // db cration strategy=> 
            // 1 - Ensure Created,
            // 2 - Migration

            // dev only => with production we use migration 

            //db.Database.EnsureDeleted();
            //db.Database.EnsureCreated(); // uses in the first table

            #endregion

            #region Crud operation

            #region Create Departments
            /*var d1 = new Department { DeptName = "IT" };
            var d2 = new Department { DeptName = "HR" };
            var d3 = new Department { DeptName = "SD" };
            var d4 = new Department { DeptName = "UI" };
            var d5 = new Department { DeptName = "UX" };

            db.Departments.AddRange(d1, d2, d3, d4, d5);
            db.SaveChanges();*/
            #endregion

            #region Create Students
            /*var s1 = new Student { Name = "Ali", Age = 22, DepartmentId = 1 };
            var s2 = new Student { Name = "Ahmed", Age = 23, DepartmentId = 1 };
            var s3 = new Student { Name = "Sara", Age = 21, DepartmentId = 2 };
            var s4 = new Student { Name = "Mona", Age = 22, DepartmentId = 3 };
            var s5 = new Student { Name = "Yara", Age = 20, DepartmentId = 1 };
            var s6 = new Student { Name = "Omar", Age = 24, DepartmentId = 2 };
            var s7 = new Student { Name = "Lina", Age = 22, DepartmentId = 3 };
            var s8 = new Student { Name = "Hana", Age = 21, DepartmentId = 4 };
            var s9 = new Student { Name = "Nada", Age = 23, DepartmentId = 1 };
            var s10 = new Student { Name = "Zina", Age = 22, DepartmentId = 5 };

            db.Students.AddRange(s1, s2, s3, s4, s5, s6, s7, s8, s9, s10);
            db.SaveChanges();*/
            #endregion

            #region Get Students & Departments
            //---> Display All Students

            /*var allStd = db.Students.ToList();
            foreach (var student in allStd)
            {
                Console.WriteLine(student);
            }*/

            //---> Display All Departments

            //var allDept = db.Departments.ToList();
            //foreach (var dept in allDept)
            //{
            //    Console.WriteLine(dept);
            //}

            //---> Students with Department Name (Include)

            //var stdDpt = db.Students.Include(s => s.Department).ToList();
            //foreach (var student in stdDpt)
            //{
            //    Console.WriteLine(student);
            //}


            //---> Students in DeptId = 1 (Include)

            //var stdinDept1 = db.Students.Include(s => s.Department).Where(s => s.DepartmentId == 1).ToList();
            //foreach(var s in stdinDept1)
            //{
            //    Console.WriteLine(s);
            //}

            //---> OrderBy Descending

            //var stdinDept1 = db.Students.Include(s => s.Department).Where(s => s.DepartmentId == 1).OrderByDescending(s => s.Name).ToList();
            //foreach (var s in stdinDept1)
            //{
            //    Console.WriteLine(s.Name);

            #endregion

            #region Update Student

            /*// v01 => catch employee from database
            var empUpdate = db.Employees.FirstOrDefault(e => e.Id == 1);
            if(empUpdate != null)
            {
                empUpdate.Name = "Habiba nezar";
                db.SaveChanges();
            }
    */

            #endregion

            #region Delete Student
            /*// catch emp from db
            var empDeleted = db.Employees.FirstOrDefault(e => e.Id == 1);
            if(empDeleted != null)
            {
                db.Remove(empDeleted);
                db.SaveChanges();
            }*/
            #endregion


            #endregion

            #region linq


            //1. Display all Student using LINQ Query Expression.
            var q1 = from std in db.Students
                     select std;

            foreach (var s in q1)
            {
                //Console.WriteLine(s);
            }




            //2. Display all Student using LINQ Method Syntax[fluent syntax].
            var q2 = db.Students.ToList();
            foreach (var s in q2)
            {
                //Console.WriteLine(s);
            }

            //3. Display all Students with Age > 30 using LINQ Query Expression.
            var q3 = from std in db.Students
                     where std.Age > 20
                     select std;

            foreach (var s in q3)
            {
                //Console.WriteLine(s);
            }

            //4. Display all Students with Salary< 5000 using LINQ Method Syntax[fluent syntax]. 
            var q4 = db.Students.Where(s => s.Salary < 50000).ToList();
            foreach (var s in q4)
            {
                //Console.WriteLine(s);
            }
            //5. Display all Students with DepartmentId = 1 and salary > 4000 OrderBy Name
            //descending using LINQ Query Expression.

            var q5 = from std in db.Students
                     where std.DepartmentId == 1 && std.Salary > 4000
                     orderby std.Name descending
                     select std;
            foreach (var s in q5)
            {
                //Console.WriteLine(s);
            }
            //6. Display all Students with DepartmentId = 1 and Name Contains ‘m’ OrderBy Salary
            //Ascending using LINQ Method Syntax[fluent syntax]. 
            var q6 = db.Students.Where(s => s.DepartmentId == 1 && s.Name.Contains("m")).OrderBy(s => s.Salary).ToList();
            foreach (var s in q6)
            {
                //Console.WriteLine(s);
            }

            //7. Find First Student with Salary more than 5000.  
            //Hint: (using First and FirstOrDefault) 
            var q7 = db.Students
                    .FirstOrDefault(s => s.Salary > 5000);

            if (q7 != null)
            {
                //Console.WriteLine(q7.Name);
            }
            //8. Find Last Student in Department number 10. 
            //Hint: (using Last and LastOrDefault) 
            var q8 = db.Students
                        .Where(s => s.DepartmentId == 1)
                        .OrderBy(s => s.Id)
                        .LastOrDefault();

            if (q8 != null)
            {
                //Console.WriteLine(q8.Name);
            }

            //9. Find Student with Age equal 25. 
            //Hint: (using Single and SingleOrDefault) 
            var q9 = db.Students
                     .SingleOrDefault(s => s.Age == 25);

            if (q9 != null)
            {
                //Console.WriteLine(q9.Name);
            }
            //10. Find Student with DepartmentId equal 8. 
            //Hint: (using Single and SingleOrDefault) 
            var q10 = db.Students
                    .SingleOrDefault(s => s.DepartmentId == 8);

            if (q10 != null)
            {
                //Console.WriteLine(q10.Name);
            }
            #endregion

        }
    }
}

