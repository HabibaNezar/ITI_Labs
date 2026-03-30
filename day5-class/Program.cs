using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5_class
{
    
    internal class Program
    {
        #region Merge Two Arrays (Question 4)
        public static Employee[] MergeArrays(Employee[] firstArr, Employee[] secondArr)
        {
            int totalN = firstArr.Length + secondArr.Length;
            Employee[] result = new Employee[totalN];
            for (int i = 0; i < firstArr.Length; i++)
            {
                result[i] = firstArr[i];
            }
            for (int i = 0; i < secondArr.Length; i++)
            {
                result[firstArr.Length + i] = secondArr[i];
            }
            return result;
        }
        #endregion

        #region Print Array (Question 5)
        public static void PrintEmployeeArray(Employee[] employees, int count)
        {
            if (employees == null || count == 0)
            {
                Console.WriteLine("The array is empty. No employees to display.");
                return;
            }

            Console.WriteLine("\n================ All Employees Data ================");
            for (int i = 0; i < count; i++)
            {
                employees[i].Print();
            }
            Console.WriteLine("====================================================");
        }
        #endregion

        #region Check if ID exists
        public static bool IsIdExists(Employee[] arr, int count, int id)
        {
            for (int i = 0; i < count; i++)
            {
                if (arr[i].GetID() == id)
                    return true;
            }
            return false;
        }
        #endregion

        #region (Question 6)

        // a- Insert new employee
        public static void InsertEmployee(Employee[] arr, ref int count)
        {
            if (count >= arr.Length)
            {
                Console.WriteLine("Array is full! Cannot insert more employees.");
                return;
            }

            Employee newEmp = new Employee();

            // Validate Unique ID
            int id;
            while (true)
            {
                Console.Write("Enter Employee ID: ");
                string input = Console.ReadLine();
                if(input.Length !=0 && int.TryParse(input, out id)){
                    if (IsIdExists(arr, count, id))
                        Console.WriteLine("Error: ID already exists. Please enter a unique ID.");
                    else
                        break;
                }
                else
                {
                    Console.WriteLine("Enter valid id");
                }
                
            }
            newEmp.SetID(id);
            
            // employee name
            while (true)
            {
                Console.Write("Enter Employee Name: ");
                string name = Console.ReadLine();
                if (name.Length != 0 && !int.TryParse(name, out int n))
                {
                    newEmp.SetName(name);
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a valid name");
                }
            }

            // security level
            while (true)
            {
                Console.Write("Enter Security Level (0: Guest, 1: Developer, 2: Secretary, 3: DBA): ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int n) && Enum.IsDefined(typeof(SecurityLevel), n))
                {
                    newEmp.SetSecurityLevel((SecurityLevel)n);
                    break; // الخروج فقط لو الرقم صحيح وموجود في الـ Enum
                }
                else
                {
                    newEmp.SetSecurityLevel((SecurityLevel) n);
                }
            }

            //salary
            while (true)
            {
                Console.Write("Enter Salary: ");
                string input =Console.ReadLine();
                if(input.Length != 0 && double.TryParse(input, out double n))
                {
                    newEmp.SetSalary(n);
                    break;
                }
                else
                {
                    Console.WriteLine("enter valid salary!");
                }
            }

            // gender
            while (true)
            {
                Console.Write("Enter Gender (M/F): ");
                string gInput = Console.ReadLine().Trim().ToUpper();
                if (gInput.Length != 0 && Enum.TryParse(gInput, out Gender gResult) && Enum.IsDefined(typeof(Gender), gResult))
                {
                    newEmp.SetGender(gResult);
                    break;
                }
                else
                {
                    Console.WriteLine(" Enter a valid gender just 'M' of 'F' ");
                }
            }

            //date
            int d;
            int m;
            int y;
            while (true)
            {
                Console.WriteLine("Enter Hire Date:");
                Console.Write("Day: ");
                string input = Console.ReadLine();
                if (input.Length != 0 && int.TryParse(input, out int n))
                {
                    if (n >= 1 && n <= 31)
                    {
                        d = n;
                        break;
                    }
                       
                    else
                    {
                        Console.WriteLine("Enter a valid day between 1 and 31");
                    }
                   
                }
                else
                {
                    Console.WriteLine("enter valid day number");
                }
            }
            while (true)
            {
                Console.WriteLine("Enter Hire Month:");
                Console.Write("Month: ");
                string input = Console.ReadLine();
                if (input.Length != 0 && int.TryParse(input, out int n))
                {
                    if (n >= 1 && n <= 12)
                    {
                        m = n;
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Enter a valid month between 1 and 12");
                    }
                   
                }
                else
                {
                    Console.WriteLine("enter valid month number");
                }
            }
            while (true)
            {
                Console.WriteLine("Enter Hire year:");
                Console.Write("year: ");
                string input = Console.ReadLine();
                if (input.Length != 0 && int.TryParse(input, out int n))
                {
                    if (n >= 2000 && n <= 2026)
                    {
                        y = n;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid year between 2000 to 2026");
                    }
                }
                else
                {
                    Console.WriteLine("enter valid year number");
                }
            }
            newEmp.SetHireDate(d, m, y);

            arr[count] = newEmp;
            count++;
            Console.WriteLine("Employee inserted successfully!");
        }

        // c- Search by id
        public static void SearchById(Employee[] arr, int count)
        {
            Console.Write("Enter ID to search: ");
            int id = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                if (arr[i].GetID() == id)
                {
                    Console.WriteLine("\nEmployee Found:");
                    arr[i].Print();
                    return;
                }
            }
            Console.WriteLine("Employee not found.");
        }

        // d- Search by name
        public static void SearchByName(Employee[] arr, int count)
        {
            Console.Write("Enter Name to search: ");
            string name = Console.ReadLine();

            bool found = false;
            for (int i = 0; i < count; i++)
            {
                if (arr[i].GetName().Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\nEmployee Found:");
                    arr[i].Print();
                    found = true;
                }
            }
            if (!found) Console.WriteLine("Employee not found.");
        }

        // f- Update employee by id
        public static void UpdateEmployee(Employee[] arr, int count)
        {
            Console.Write("Enter ID of employee to update: ");
            int id = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                if (arr[i].GetID() == id)
                {
                    Console.WriteLine("Employee found. Enter new details (ID cannot be changed).");

                    Console.Write("Enter New Name: ");
                    arr[i].SetName(Console.ReadLine());

                    Console.Write("Enter New Security Level (0: Guest, 1: Developer, 2: Secretary, 3: DBA): ");
                    arr[i].SetSecurityLevel((SecurityLevel)int.Parse(Console.ReadLine()));

                    Console.Write("Enter New Salary: ");
                    arr[i].SetSalary(double.Parse(Console.ReadLine()));

                    Console.Write("Enter New Gender (M/F): ");
                    string gInput = Console.ReadLine().Trim().ToUpper();
                    arr[i].SetGender(gInput == "M" ? Gender.M : Gender.F);

                    Console.WriteLine("Enter New Hire Date:");
                    Console.Write("Day: ");
                    int d = int.Parse(Console.ReadLine());
                    Console.Write("Month: ");
                    int m = int.Parse(Console.ReadLine());
                    Console.Write("Year: ");
                    int y = int.Parse(Console.ReadLine());
                    arr[i].SetHireDate(d, m, y);

                    Console.WriteLine("Employee updated successfully!");
                    return;
                }
            }
            Console.WriteLine("Employee not found.");
        }

        // g- Delete employee by id
        public static void DeleteEmployee(Employee[] arr, ref int count)
        {
            Console.Write("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                if (arr[i].GetID() == id)
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    count--;
                    Console.WriteLine("Employee deleted successfully!");
                    return;
                }
            }
            Console.WriteLine("Employee not found.");
        }


        #endregion
        static void Main(string[] args)
        {
            // Create an empty array of 10 employees
            Employee e1= new Employee((SecurityLevel)2);

            Employee[] companyEmployees = new Employee[10];
            int employeeCount = 0;

            string choice;

            do
            {
                Console.WriteLine("\n======== Employee Management System ========");
                Console.WriteLine("a- Insert new employee");
                Console.WriteLine("b- Display inserted employees only");
                Console.WriteLine("c- Search by id");
                Console.WriteLine("d- Search by name");
                Console.WriteLine("e- Count number of inserted employees");
                Console.WriteLine("f- Update employee by id");
                Console.WriteLine("g- Delete employee by id");
                Console.WriteLine("h- Exit");
                Console.Write("Enter your choice: ");
                choice = Console.ReadLine().ToLower();

                Console.WriteLine(); // empty line for readability

                switch (choice)
                {
                    case "a":
                        InsertEmployee(companyEmployees, ref employeeCount);
                        break;
                    case "b":
                        PrintEmployeeArray(companyEmployees, employeeCount);
                        break;
                    case "c":
                        SearchById(companyEmployees, employeeCount);
                        break;
                    case "d":
                        SearchByName(companyEmployees, employeeCount);
                        break;
                    case "e":
                        Console.WriteLine($"Total number of inserted employees: {employeeCount}");
                        break;
                    case "f":
                        UpdateEmployee(companyEmployees, employeeCount);
                        break;
                    case "g":
                        DeleteEmployee(companyEmployees, ref employeeCount);
                        break;
                    case "h":
                        Console.WriteLine("Exiting program... Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a letter from a to h.");
                        break;
                }
            } while (choice != "h");

        }
    }
}