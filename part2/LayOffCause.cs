using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2
{
    public enum LayOffCause
    {
        VacationStockNegative,
        AgeOver60,
        FailedTarget,
        Resigned
    }

    public class EmployeeLayOffEventArgs : EventArgs
    {
        public LayOffCause Cause { get; set; }
    }
}
