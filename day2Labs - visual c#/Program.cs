namespace day2Labs___visual_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] EmpArr = new Employee[3];

            Console.WriteLine("=== Employee Data Entry ===");

            for (int i = 0; i < EmpArr.Length; i++)
            {
                Console.WriteLine($"\n--- Entering data for Employee {i + 1} ---");

                int id;
                Console.Write("Enter ID: ");
                while (!int.TryParse(Console.ReadLine(), out id))
                {
                    Console.Write("Invalid input. Please enter a valid integer ID: ");
                }

                decimal salary;
                Console.Write("Enter Salary: ");
                while (!decimal.TryParse(Console.ReadLine(), out salary))
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

                HiringDate hireDate = new HiringDate(day, month, year);
                EmpArr[i] = new Employee(id, salary, hireDate, gender);
            }

            // Displaying Data
            Console.WriteLine("\n=== Registered Employees ===");
            foreach (Employee emp in EmpArr)
            {
                Console.WriteLine(emp.ToString());
            }
        }
    }
}
