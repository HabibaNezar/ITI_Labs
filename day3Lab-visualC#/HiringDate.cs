using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3Lab_visualC_
{
    internal struct HiringDate
    {
		// private fields
		private int day;
        private int month;
        private int year;

        // properties
        public int Day
		{
			get { return day; }
			set 
            { 
                if(value > 0 && value <= 31)
                {
                    day = value;
                }
                else
                {
                    throw new Exception(" Enter a valid day between 1:30 ");
                }
            }
		}
        public int Month
        {
            get { return month; }
            set
            {
                if (value > 0 && value <= 12)
                {
                    month = value;
                }
                else
                {
                    throw new Exception(" Enter a valid month between 1:12 ");
                }
            }
        }
        public int Year
        {
            get { return year; }
            set
            {
                if (value > 1999  && value <= DateTime.Now.Year)
                {
                    year = value;
                }
                else
                {
                    throw new Exception($" Enter a valid year between 2000:{DateTime.Now.Year}");
                }
            }
        }

        // constructor
        public HiringDate(int d, int m, int y){
            Day = d;
            Month = m;
            Year = y;
        }

        // methods
        public string Print()
        {
            return($"{Day}/{Month}/{Year}");
        }
    
        public static bool operator ==(HiringDate h1, HiringDate h2)
        {
            return h1.Day == h2.Day &&
                    h1.month == h2.Month &&
                    h1.Year == h2.Year;
        }
        public static bool operator !=(HiringDate h1, HiringDate h2)
        {
            return !(h1.Day == h2.Day &&
                    h1.month == h2.Month &&
                    h1.Year == h2.Year);
        }
    }

}
