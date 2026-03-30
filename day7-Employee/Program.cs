using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7_Employee
{
    internal class Program
    {
        // metods 
        public static Employee GetEmployeeWithLongestClientsArray(Employee[] arr)
        {
            if (arr == null || arr.Length == 0) return null;

            Employee maxEmployee = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i].Clients != null && maxEmployee.Clients != null)
                {
                    if (arr[i].Clients.Length > maxEmployee.Clients.Length)
                    {
                        maxEmployee = arr[i];
                    }
                }
            }
            return maxEmployee;
        }
        static void Main(string[] args)
        {
            // clients
            Client c1 = new Client(1, "ahmed", "Tanta");
            Client c2 = new Client(2, "Habiba", "Tanta");
            Client c3 = new Client(3, "Basma", "Tanta");
            Client c4 = new Client(4, "Basma", "Tanta");
            Client c5 = new Client(5, "Basma", "Tanta");

            // HR Employees
            HREmployee hr1 = new HREmployee(11, "habiba", 50000, 3, new Client[] { c1,c2, c3});
            HREmployee hr2 = new HREmployee(22, "ahmed", 100000, 2, new Client[] { c1, c2 });

            // PR Employees
            PREmployee pr1 = new PREmployee(11, "habiba", 50000, 4, new Client[] { c1, c2, c3, c4 });
            PREmployee pr2 = new PREmployee(22, "ahmed", 100000, 5, new Client[] { c1, c2, c3, c4, c5 });

            // array of hr employee and pr employee
            Employee[] empArr = new Employee[]
            {
                hr1,
                hr2,
                pr1,
                pr2,
            };

            // test GetEmployeeWithLongestClientsArray
            GetEmployeeWithLongestClientsArray(empArr).ShowEmployeeDetails();

            // test overloading operator
            HREmployee hr3 = hr1 + hr2;
            Console.Write($"hr1 + hr2 = ");
            hr3.ShowEmployeeDetails();
            Console.WriteLine($"hr1 > hr2 = {hr1 > hr2}");
            Console.WriteLine($"hr1 >= hr2 = {hr1 >= hr2}");
        }
    }
}
