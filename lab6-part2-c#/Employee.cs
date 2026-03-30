using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_part2_c_
{
    public class Employee
    {
        #region events
        // 2- event declaration
        public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;

        // 3- method to fire event
        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {

            EmployeeLayOff?.Invoke(this, e);

        }
        #endregion


        #region prop
        public int EmployeeID { get; set; }
        public DateTime BirthDate { get ; set ; }
        public int VacationStock { get; set; }
        #endregion

        #region methods
            public bool RequestVacation(DateTime From, DateTime To)
            {
                int vacDays = (To - From).Days;
                VacationStock -= vacDays;
                if(VacationStock < 0)
            {
                // 4- firing for event
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.vacationStockNegative });
                   return false;
            }
                return true;
            }

            public void EndOfYearOperation()
            {
            int ageNow = DateTime.Now.Year - BirthDate.Year;
            if (ageNow >= 60)
            {
                // firing event
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.ageOver60 });
            }
            }
        #endregion



    }

    public enum LayOffCause
    {
        vacationStockNegative, ageOver60
    }

    // 1- inherit from EventArgs
    public class EmployeeLayOffEventArgs:EventArgs
    {
        public LayOffCause Cause { get; set; }
    }

}
