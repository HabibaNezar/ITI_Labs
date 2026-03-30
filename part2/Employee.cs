using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2
{
    internal class Employee
    {
        public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;

        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            // Safely invoke the event if there are subscribers
            EmployeeLayOff?.Invoke(this, e);
        }

        public int EmployeeID { get; set; }
        public DateTime BirthDate { get; set; }
        public int VacationStock { get; set; }

        // Virtual so it can be overridden by SalesPerson and BoardMember
        public virtual bool RequestVacation(DateTime From, DateTime To)
        {
            int daysRequested = (To - From).Days;
            VacationStock -= daysRequested;

            if (VacationStock < 0)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.VacationStockNegative });
                return false; // Vacation request ultimately led to layoff
            }
            return true;
        }

        // Virtual so it can be overridden by BoardMember
        public virtual void EndOfYearOperation()
        {
            // Calculate age
            int age = DateTime.Now.Year - BirthDate.Year;
            if (DateTime.Now.DayOfYear < BirthDate.DayOfYear) age--;

            if (age > 60)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.AgeOver60 });
            }
        }
    }
}
