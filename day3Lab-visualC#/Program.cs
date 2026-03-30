namespace day3Lab_visualC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Array of Employees with size three ===");
            Employee[] emps = new Employee[] {
               new Employee(1, 80000, 80000, new HiringDate(20,8,2000), Gender.M, SecurityPrivileges.Guest),
               new Employee(2, 40000, 40000, new HiringDate(20,8,2020), Gender.F, SecurityPrivileges.Secretary),
               new Employee(3, 50000, 40000, new HiringDate(20,8,2025), Gender.F, SecurityPrivileges.Developer),
            };
            foreach(Employee emp in emps)
            {
                Console.WriteLine(emp.ToString());
            }
            
            # region Read ALL Data from End User
            
            /*Console.WriteLine("=== Read ALL Data from End User ===");
            Console.Write("Enter array number: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Enter valid array number: ");
            }

            Employee[] EmpArr = new Employee[n];

            for (int i = 0; i < EmpArr.Length; i++)
            {
                Console.WriteLine($"\n--- Entering data for Employee {i + 1} ---");

                int id;
                Console.Write("Enter ID: ");
                while (!int.TryParse(Console.ReadLine(), out id))
                {
                    Console.Write("Invalid input. Please enter a valid integer ID: ");
                }

                int salary;
                Console.Write("Enter Salary: ");
                while (!int.TryParse(Console.ReadLine(), out salary))
                {
                    Console.Write("Invalid input. Please enter a valid decimal for Salary: ");
                }

                Gender gender;
                Console.Write("Enter Gender (M or F): ");
                while (!Enum.TryParse(Console.ReadLine(), true, out gender) || !Enum.IsDefined(typeof(Gender), gender))
                {
                    Console.Write("Invalid input. Please enter exactly M or F: ");
                }

                Console.WriteLine("Enter Hiring Date Details:");

                int day;
                Console.Write("  Day (1-31): ");
                while (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 31)
                {
                    Console.Write("  Invalid Day. Enter a number between 1 and 31: ");
                }

                int month;
                Console.Write("  Month (1-12): ");
                while (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12)
                {
                    Console.Write("  Invalid Month. Enter a number between 1 and 12: ");
                }

                int year;
                Console.Write("  Year (1900-2026): ");
                while (!int.TryParse(Console.ReadLine(), out year) || year < 1900 || year > DateTime.Now.Year)
                {
                    Console.Write("  Invalid Year. Enter a valid year: ");
                }

                SecurityPrivileges security;
                Console.WriteLine("Enter privileges number:");
                Console.WriteLine("1- Guest");
                Console.WriteLine("2- Developer");
                Console.WriteLine("4- Secretary");
                Console.WriteLine("8- DBA");
                int privInput;
                while (!int.TryParse(Console.ReadLine(), out privInput) || (privInput & ~15) != 0)
                {
                    Console.WriteLine("Invalid input. Enter combination of 1,2,4,8");
                }
                security = (SecurityPrivileges)privInput;

                HiringDate hireDate = new HiringDate(day, month, year);
                EmpArr[i] = new Employee(id, salary, hireDate, gender, security);
            }

            foreach (Employee emp in EmpArr)
            {
                Console.WriteLine(emp.ToString());
            }*/
            #endregion

            #region test Emp Struct equality
            
            Employee e1 = new Employee(11, 50000, 10000, new HiringDate(5, 5, 2005), Gender.F, SecurityPrivileges.Developer);
            Employee e2 = new Employee(12, 50000, 10000, new HiringDate(5, 5, 2005), Gender.F, SecurityPrivileges.Developer);
            Console.WriteLine($"is e1 = e2 {e1.Equals(e2)}");

            #endregion

            #region apply Interfaces

            #region ipayable
                IPayable[] staff =
                {
                    new Employee(111, 20000, 1000, new HiringDate(20,8,2000), Gender.M, SecurityPrivileges.Guest),
                    new Employee(222, 50000, 5000, new HiringDate(20,8,2000), Gender.M, SecurityPrivileges.Guest)
                };
            #endregion

            #region icomparable
                Array.Sort(emps);
            foreach (Employee emp in emps) {
                Console.WriteLine(emp);
            };
            #endregion
            
            #endregion
        
        }
    }
}
