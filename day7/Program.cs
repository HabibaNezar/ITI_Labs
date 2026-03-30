using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Duration D1 = new Duration(1, 10, 15);
            Duration D2 = new Duration(3600);
            Duration D3 = new Duration(7800);
            Duration D4 = new Duration(666);
            Console.WriteLine("--- Duration Examples display ---");
            Console.Write($"Time of duration 1, 10, 15 =  ");
            D1.Print();
            Console.Write($"Time of duration 3600      =  ");
            D2.Print();
            Console.Write($"Time of duration 7800      =  ");
            D3.Print();
            Console.Write($"Time of duration 666       =  ");
            D4.Print();

            Console.WriteLine("--- Apply operators ---");
            Console.WriteLine($"D1 + D2   = {D1 + D2}");
            Console.WriteLine($"D1 + 7800 = {D1 + 7800}");
            Console.WriteLine();
            Console.WriteLine($"D1 > D2   = {D1 > D2}");
            Console.WriteLine($"D1 <= D2  = {D1 <= D2}");
        }
    }
}
