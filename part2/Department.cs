using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2
{
    internal class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }

        // Initialized the list to prevent NullReferenceExceptions
        List<Employee> Staff = new List<Employee>();

        public void AddStaff(Employee E)
        {
            Staff.Add(E);
            // Register for EmployeeLayOff Event
            E.EmployeeLayOff += RemoveStaff;
        }

        /// CallBackMethod
        public void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
        {
            if (sender is Employee emp)
            {
                Staff.Remove(emp);
                Console.WriteLine($"Employee {emp.EmployeeID} removed from Department {DeptName}. Cause: {e.Cause}");
            }
        }
    }
}
