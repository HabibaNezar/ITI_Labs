using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_lab
{
    internal class Helper
    {
        public static void PrintList<T>(IEnumerable<T> list)
        {
            int count = 0;
            foreach(var item in  list)
            {
                Console.WriteLine(" " + item);
                count++;
            }
            if(count == 0) Console.WriteLine("no results found");
            Console.WriteLine($"total {count} records");
        }
    }
}
