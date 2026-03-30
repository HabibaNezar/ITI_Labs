using LINQDemo;
using static linq_lab.Program;

namespace linq_lab
{


    internal class Program
    {
        public class Book
        {
            public string Title { get; set; }
            public string ISBN { get; set; }
            public decimal Price { get; set; }

            public Publisher Publisher { get; set; }
            public bSubject Subject { get; set; }
        }

        public class Publisher
        {
            public string Name { get; set; }
        }

        public class bSubject
        {
            public string Name { get; set; }
        }

        public static void FindStudentsSorted(int m, int w, List<Student> students)
        {
            if (m == 1 && w == 1)
            {
                Helper.PrintList(students.OrderBy(s => s.FirstName));
            }
            else if (m == 1 && w == 2)
            {
                Helper.PrintList(students.OrderByDescending(s => s.FirstName));
            }
            else if (m == 2 && w == 1)
            {
                Helper.PrintList(students.OrderBy(s => s.Age));
            }
            else if (m == 2 && w == 2)
            {
                Helper.PrintList(students.OrderByDescending(s => s.Age));
            }
            else if (m == 3 && w == 1)
            {
                Helper.PrintList(students.OrderBy(s => s.Salary));
            }
            else if (m == 3 && w == 2)
            {
                Helper.PrintList(students.OrderByDescending(s => s.Salary));
            }
        }
        static void Main(string[] args)
        {
            List<Student> students = RepositoryStd.GetStudents();
            List<Track> tracks = RepositoryStd.GetTracks();

            List<Employee> employees = RepositoryEmp.GetEmployees();
            List<Department> departments = RepositoryEmp.GetDepartments();

            #region file1
            // ---file 1-- -


            //------------ 1.Display all Student using LINQ Query Expression. 
            var q1 = from s in students
                     select s;
            //Helper.PrintList(q1);

            //------------ 2.Display all Student using LINQ Method Syntax[fluent syntax].
            var q2 = students.Select(s => s);
            //Helper.PrintList(q2);

            //------------ 3.Display all Students with Age > 30 using LINQ Query Expression.
            var q3 = from s in students
                     where s.Age > 30
                     select s;
            //Helper.PrintList(q3);

            //------------ 4.Display all Students with Salary< 5000 using LINQ Method Syntax[fluent syntax].
            var q4 = students.Where(s => s.Salary < 5000);
            //Helper.PrintList(q4);

            //------------ 5.Display all Students with TrackId = 1 and salary > 4000 OrderBy Name descending using LINQ Query Expression.
            var q5 = from s in students
                     where s.TrackId == 1 && s.Salary > 4000
                     orderby s.FirstName descending
                     select s;

            //Helper.PrintList(q5);


            //------------ 6.Display all Students with TrackId = 1 and first name Contains ‘m’ OrderBy Salary Ascending using LINQ Method Syntax[fluent syntax].
            var q6 = students.Where(s => s.TrackId == 1 && s.FirstName.Contains("m", StringComparison.OrdinalIgnoreCase))
                              .OrderBy(s => s.Salary);

            //Helper.PrintList(q6);

            //------------ 7.Find First Student with Salary more than 5000.Hint: (using First and FirstOrDefault and Explain difference)
            var q7first = students.First(s => s.Salary == 5000);
            var q7firstdefault = students.FirstOrDefault(s => s.Salary == 5000);

            //Console.WriteLine("first           : " + q7first);
            //Console.WriteLine("first or default: " + q7firstdefault);

            // the diff is first            => return first value and if it not exist throw exeption 
            //             first or default => if condetion not exist return null

            //------------ 8.Find Last Student in Track number 10.Hint: (using Last and LastOrDefault and Explain difference)
            var q8last = students.Last(s => s.TrackId == 10);
            var q8lastordefault = students.LastOrDefault(s => s.TrackId == 10);

            /* Console.WriteLine("last           : " + q8last);
             Console.WriteLine("last or default: " + q8lastordefault);*/

            // diff is the last throw exection if not fount but with or default return null

            //------------ 9.Find Student with Age equal 25.Hint: (using Single and SingleOrDefault and Explain difference)
            /*var q9single = students.Single(s => s.Age == 25);
            var q9singledefault = students.SingleOrDefault(s => s.Age == 25);*/

            /*Console.WriteLine(q9single);
            Console.WriteLine(q9singledefault);*/
            // diff => both return exeption if there are more than one value => single throw exeption if not found unlike with default which return null

            //------------ 10.Find Student with TrackId equal 8.Hint: (using Single and SingleOrDefault and Explain difference)
            /*var q10single = students.Single(s => s.TrackId == 8);
            var q10singledefault = students.SingleOrDefault(s => s.TrackId == 8);*/

            /*Console.WriteLine(q10single);
            Console.WriteLine(q10singledefault);*/

            //------------ 11.Find Student in index 4.
            var q11 = students.ElementAt(4);
            //Console.WriteLine("index" + q11);

            //------------ 12.Ask the user for sorting method (by Name, Age, etc….) and sorting way(ASC.Or DESC.)…. And implement a function named FindStudentsSorted() that displays all Students sorted as the user requested
            /* Console.WriteLine("choose the number that you want to sort by ");
             Console.WriteLine("1- Name");
             Console.WriteLine("2- Age");
             Console.WriteLine("3- Salary");
             int method;
             int way;
             while (!int.TryParse(Console.ReadLine(), out method) && (method == 1 || method == 2 || method == 3))
             {
                 Console.WriteLine("choose valid number");
                 Console.WriteLine("1- Name");
                 Console.WriteLine("2- Age");
                 Console.WriteLine("3- Salary");
             }
             Console.WriteLine("choose the number that you want to sort by ");
             Console.WriteLine("1- Asc");
             Console.WriteLine("2- Des");
             while (!int.TryParse(Console.ReadLine(), out way) && (way == 1 || way == 2))
             {
                 Console.WriteLine("choose valid number");
                 Console.WriteLine("1- Asc");
                 Console.WriteLine("2- Des");
             }*/

            //FindStudentsSorted(method, way, students);

            #endregion

            #region file2
            //1.First 4 Employees in the List Using Method Syntax[fluent syntax].
            var q2_1 = students.Take(4);
            //Helper.PrintList(q2_1);

            //2.First 3 Employees in the List with Salary more than 5000 Using Method Syntax[fluent syntax].
            var q2_2 = students.Where(e => e.Salary > 5000).Take(3);
            //Helper.PrintList(q2_2);

            //3.Last 4 Employees in the List Using Method Syntax[fluent syntax]. 
            var q2_3 = students.TakeLast(4);
            //Helper.PrintList(q2_3);

            //4.Second 2 Employees in the List Using Method Syntax[fluent syntax]. 
            var q2_4 = students.Skip(1).Take(2);
            //Helper.PrintList(q2_4);

            //5.All Employees While Name length< 5 Using Method Syntax[fluent syntax]. 
            var q2_5 = students.Where(e => e.FirstName.Length < 5);
            //Helper.PrintList(q2_5);

            //6.Distinct Employees.Hint: (Using IEqualityComparer) Using Method Syntax[fluent syntax]. 
            var q2_6 = students.Distinct(new StudentComparer());
            //Helper.PrintList(q2_6);

            //7.Name and Id of All Employees Using Method Syntax[fluent syntax]. 
            var q2_7 = students.Select(e => new { e.FirstName, e.Id });
            //Helper.PrintList(q2_7);

            //8.Name and Id of All Employees Using Query Syntax.
            var q2_8 = from s in students
                       select new { s.Id, s.FirstName };
            //Helper.PrintList(q2_8);

            //9.Name and DeptName of All Employees Using Query Syntax. 
            var q2_9 = from e in employees
                       join d in departments
                       on e.DeptId equals d.DeptId
                       select new { e.Name, d.DeptName };
            //Helper.PrintList(q2_9);

            //10.Name and DeptName of All Employees Using Method Syntax[fluent syntax]. 
            var q2_10 = employees.Join(
                        departments,
                        e => e.DeptId,
                        d => d.DeptId,
                        (e, d) => new { e.Name, d.DeptName });
            //Helper.PrintList(q2_10);

            //11.All Employees Group by DeptName Using Method Syntax[fluent syntax]. 
            var q2_11 = employees.Join(
                        departments,
                        e => e.DeptId,
                        d => d.DeptId,
                        (e, d) => new { e.Name, d.DeptName }).GroupBy(d => d.DeptName);
            /*foreach (var group in q2_11)
            {
                Console.WriteLine(group.Key); // dept name
                foreach (var emp in group)
                {
                    Console.WriteLine(emp.Name);
                }
            }*/

            //12.All Employees Group by DeptName Using Query Syntax.
            var q2_12 = from e in employees
                        join d in departments
                        on e.DeptId equals d.DeptId
                        group e by d.DeptName into g
                        select new { g.Key, g };
            //Helper.PrintList(q2_12);
            /*foreach (var group in q2_12)
            {
                Console.WriteLine(group.Key); // dept name
                foreach (var emp in group.g)
                {
                    Console.WriteLine(emp.Name);
                }
            }*/

            //13.Min Salary, Max Salary, Avg Salary.

            /*Console.WriteLine(employees.Min(e => e.Salary));
            Console.WriteLine(employees.Max(e => e.Salary));
            Console.WriteLine(employees.Average(e => e.Salary));*/

            //14.Employee Where Salary<Avg Salary. 
            var q2_14 = employees.Where(e => e.Salary < employees.Average(s => s.Salary));
            //Helper.PrintList(q2_14);

            //15.Create two lists of int and try Expect, Concat, Union, Intersect. 
            var list1 = new List<int> { 1, 2, 3, 4, 5 };
            var list2 = new List<int> { 4, 5, 6, 7, 8 };
            var exceptResult = list1.Except(list2); // 1, 2, 3

            /*Console.WriteLine("Except:");
            foreach (var x in exceptResult)
                Console.Write(x);
            var concatResult = list1.Concat(list2); // 1,2,3,4,5,4,5,6,7,8

            Console.WriteLine("\nConcat:");
            foreach (var x in concatResult)
                Console.Write(x);
            var unionResult = list1.Union(list2); // 1,2,3,4,5,6,7,8

            Console.Write("\nUnion:");
            foreach (var x in unionResult)
                Console.Write(x);*/
            //16.Create list of Phone Number and Names and try Zip Operator.
            var phoneNumbers = new List<string> { "0101111111", "0102222222", "0103333333" };
            var names = new List<string> { "Ali", "Sara", "Mona" };
            var zipped = names.Zip(phoneNumbers, (name, phone) => new
            {
                Name = name,
                Phone = phone
            });
            /*foreach (var item in zipped)
            {
                Console.WriteLine($"{item.Name} -> {item.Phone}");
            }*/
            #endregion

            #region file3

            #region Q1
            //--Query1
            List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };
            var q3_1 = numbers.Distinct().OrderBy(x => x);
            //Helper.PrintList(q3_1);

            //--Query2
            for (int i = 0; i < q3_1.Count(); i++)
            {
                //Console.WriteLine($"Number = {q3_1.ElementAt(i)}, Multiply = {q3_1.ElementAt(i) * q3_1.ElementAt(i)}");
            }
            #endregion

            #region Q2
            string[] _names = { "Tom", "Dick", "Harry", "MARY", "Jay" };
            //--Query1
            //Select names with length equal 3.
            // query expression
            var qu1 = from n in _names
                      where n.Length == 3
                      select n;
            //Helper.PrintList(qu1);

            // method expresion
            var que1exp = _names.Where(n => n.Length == 3);
            //Helper.PrintList(que1exp);

            //--Query2
            //Select names that contains “a” letter (Capital or Small )then sort them by length (Use toLower method and Contains method)
            // query expression
            var qu2 = from n in _names
                      where n.ToLower().Contains("a")
                      orderby n.Length
                      select n;

            //Helper.PrintList(qu2);
            // method expresion
            var qu2exp = _names
                .Where(e => e.ToLower().Contains("a"))
                .OrderBy(e => e.Length);

            //Helper.PrintList(qu2exp);
            //--Query3
            // query expression
            var qu3 = (from n in _names
                       select n).Take(2);

            //Helper.PrintList(qu3);
            // method expresion
            var qu3exp = _names.Select(n => n).Take(2);
            //Helper.PrintList(qu3exp);
            #endregion

            #region Q3
            List<Student> _students = new List<Student>()
            {
                new Student()
                {
                    Id = 1,
                    FirstName = "Ali",
                    LastName = "Mohammed",
                    Subject = new Subject[]
                    {
                        new Subject(){ Code = 22, Name = "EF" },
                        new Subject(){ Code = 33, Name = "UML" }
                    }
                },

                new Student()
                {
                    Id = 2,
                    FirstName = "Mona",
                    LastName = "Gala",
                    Subject = new Subject[]
                    {
                        new Subject(){ Code = 22, Name = "EF" },
                        new Subject(){ Code = 34, Name = "XML" },
                        new Subject(){ Code = 25, Name = "JS" }
                    }
                },

                new Student()
                {
                    Id = 3,
                    FirstName = "Yara",
                    LastName = "Yousf",
                    Subject = new Subject[]
                    {
                        new Subject(){ Code = 22, Name = "EF" },
                        new Subject(){ Code = 25, Name = "JS" }
                    }
                },

                new Student()
                {
                    Id = 1,
                    FirstName = "Ali",
                    LastName = "Ali",
                    Subject = new Subject[]
                    {
                        new Subject(){ Code = 33, Name = "UML" }
                    }
                }
            };
            //--Query1
            var que1 = _students.Select(e => new { fullName = e.FirstName + " " + e.LastName, subCount = e.Subject.Length });
            // Helper.PrintList(que1);

            //--Query2
            var que2 = _students.OrderByDescending(s => s.FirstName)
                                .ThenBy(s => s.LastName)
                                .Select(s => new { fullname = s.FirstName + " " + s.LastName });
            //Helper.PrintList(que2);

            //--Query3
            var que3 = _students.SelectMany(
                s => s.Subject,
                (s, sub) => new
                {
                    fullName = $"{s.FirstName} {s.LastName}",
                    subjectName = sub.Name
                });
            //Helper.PrintList(que3);

            //--Query3
            var que4 = _students
            .SelectMany(
                s => s.Subject,
                (s, sub) => new
                {
                    fullName = $"{s.FirstName} {s.LastName}",
                    subjectName = sub.Name
                })
            .GroupBy(x => x.fullName);
            /*foreach (var group in que4)
            {
                Console.WriteLine(group.Key); 

                foreach (var item in group)
                {
                    Console.WriteLine($"   - {item.subjectName}");
                }
            }*/
            #endregion


            #endregion

            #region file4

            List<Book> books = new List<Book>()
            {
                new Book { Title = "C# Basics", ISBN = "111", Price = 30, Publisher = new Publisher { Name = "MS" }, Subject = new bSubject { Name = "Programming" } },
                new Book { Title = "Java", ISBN = "222", Price = 20, Publisher = new Publisher { Name = "Oracle" }, Subject = new bSubject { Name = "Programming" } },
                new Book { Title = "SQL", ISBN = "333", Price = 40, Publisher = new Publisher { Name = "MS" }, Subject = new bSubject { Name = "Database" } },
                new Book { Title = "HTML", ISBN = "444", Price = 15, Publisher = new Publisher { Name = "W3" }, Subject = new bSubject { Name = "Web" } },
                new Book { Title = "CSS", ISBN = "555", Price = 35, Publisher = new Publisher { Name = "W3" }, Subject = new bSubject { Name = "Web" } }
            };

            //1- Display book title and its ISBN. 
            var q4_1 = books.Select(b => new { b.Title, b.ISBN });
            //Helper.PrintList(q4_1);


            //2- Display the first 3 books with price more than 25.
            var q4_2 = books.Where(b => b.Price > 25).Take(3);
            /*foreach (var book in q4_2)
            {
                Console.WriteLine($"{book.Title} - {book.Price}");

            }*/
            //3- Display Book title along with its publisher name. 
            var q4_3 = books.Select(b =>new { b.Title , pubName = b.Publisher.Name });
            //Helper.PrintList(q4_3);
            //4- Find the number of books which cost more than 20.
            var q4_4 = books.Count(b => b.Price > 20);

            //Console.WriteLine(q4_4);
            //5- Display book title, price and subject name sorted by its subject name ascending and by its price descending.
            var q4_5 = books.OrderBy(b => b.Subject.Name)
                .ThenByDescending(b => b.Price)
                .Select(b => new
                {
                    b.Title,
                    b.Price,
                    SubjectName = b.Subject.Name
                });
            //Helper.PrintList(q4_5);
            //6- Display all subjects with books related to this subject. (Using 2 methods). 
            var q4_6 = books
                .GroupBy(b => b.Subject.Name);
/*            foreach (var group in q4_6)
            {
                Console.WriteLine(group.Key);
                foreach (var book in group)
                {
                    Console.WriteLine($"   - {book.Title}");
                }
            }*/
            //7- Display books grouped by publisher & Subject.
            var q4_7 = books
                .GroupBy(b => new { Publisher = b.Publisher.Name, Subject = b.Subject.Name });

            /*foreach (var group in q4_7)
            {
                Console.WriteLine(group.Key); // اسم الـ Subject
                foreach (var book in group)
                {
                    Console.WriteLine($"   - {book.Title}");
                }
            }*/
            #endregion

        }
    }
}
