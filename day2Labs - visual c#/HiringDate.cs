using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2Labs___visual_c_
{
    internal class HiringDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        // Constructor
        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }

        // Compare state, not identity
        public override bool Equals(object obj)
        {
            if (obj is HiringDate other)
            {
                return Day == other.Day && Month == other.Month && Year == other.Year;
            }
            return false;
        }

        
    }
}
