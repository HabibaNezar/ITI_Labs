using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2
{
    internal class Club
    {
        public int ClubID { get; set; }
        public String ClubName { get; set; }

        // Initialized the list
        List<Employee> Members = new List<Employee>();

        public void AddMember(Employee E)
        {
            Members.Add(E);
            // Register for EmployeeLayOff Event
            E.EmployeeLayOff += RemoveMember;
        }

        /// CallBackMethod
        public void RemoveMember(object sender, EmployeeLayOffEventArgs e)
        {
            if (sender is Employee emp)
            {
                // Board Members are NEVER removed from the club
                if (emp is BoardMember)
                {
                    return;
                }

                // Standard employees are NOT removed if the cause is Age > 60
                if (e.Cause == LayOffCause.AgeOver60)
                {
                    return;
                }

                // For all other layoff causes (like VacationStockNegative or FailedTarget), remove them
                Members.Remove(emp);
                Console.WriteLine($"Employee {emp.EmployeeID} removed from Club {ClubName}. Cause: {e.Cause}");
            }
        }
    }
}
