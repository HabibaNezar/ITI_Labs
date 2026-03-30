using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7
{
    internal class Duration
    {
        // fields
        int h, m, s;

        // properties
        public int H
        {
            get { return h; }
            set { h = value; }
        }
        public int M
        {
            get { return m; }
            set { m = value; }
        }
        public int S
        {
            get { return s; }
            set { s = value; }
        }

        // constructors

        public Duration()
        {
            Console.WriteLine("welcome from default constructor");
        }
        public Duration(int hour, int min, int sec)
        {
            h = hour;
            m = min;
            s = sec;
        }

        public Duration(int d)
        {
            h = d / 3600;
            m = (d % 3600) / 60;
            s = d % 60;
        }

        // methods

        public static int timeToDuration(Duration D)
        {
            int duration = (D.H * 3600) + (D.M * 60) * D.S;
            return duration;
        }

        // --- Operator Overloading ---
        // operator +
        public static int operator+ (Duration D1, Duration D2)
        {
            int result = timeToDuration(D1) + timeToDuration(D2);
            return result;
        }

        public static int operator +(Duration D1, int D2)
        {
            int result = timeToDuration(D1) + D2;
            return result;
        }

        // operator > & <
        public static bool operator > (Duration D1, Duration D2)
        {
            return (timeToDuration(D1) > timeToDuration(D2));
        }

        public static bool operator < (Duration D1, Duration D2)
        {
            return timeToDuration(D1) < timeToDuration(D2);
        }

        public static bool operator<= (Duration D1, Duration D2)
        {
            return (timeToDuration(D1) <= timeToDuration(D2));
        }

        public static bool operator >= (Duration D1, Duration D2)
        {
            return timeToDuration(D1) >= timeToDuration(D2);
        }


        public void Print()
        {
            if (h == 0 && m == 0)
            {
                Console.WriteLine($"Seconds: {s}");
            }
            else if (h == 0)
            {
                Console.WriteLine($"Minutes: {m}, Seconds: {s}");
            }
            else
            {
                Console.WriteLine($"Hours: {h}, Minutes: {m}, Seconds: {s}");
            }
        }
    }

}
