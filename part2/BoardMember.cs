using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2
{
    internal class BoardMember : Employee
    {
        // Overridden so age > 60 doesn't trigger layoff
        public override void EndOfYearOperation()
        {
            // Do nothing
        }

        // Overridden so vacation stock doesn't apply
        public override bool RequestVacation(DateTime From, DateTime To)
        {
            // Do nothing
            return true;
        }

        public void Resign()
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.Resigned });
        }
    }
}
