using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2
{
    internal class SalesPerson : Employee
    {
        public int AchievedTarget { get; set; }

        // Overridden so vacation stock doesn't apply and won't trigger layoff
        public override bool RequestVacation(DateTime From, DateTime To)
        {
            return true;
        }

        public bool CheckTarget(int Quota)
        {
            if (AchievedTarget < Quota)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.FailedTarget });
                return false;
            }
            return true;
        }
    }
}
