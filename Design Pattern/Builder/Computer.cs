using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Computer
    {
        public string Processor { get; set; }
        public int RAM { get; set; }
        public int Storage { get; set; }
        public bool HasGraphicsCard { get; set; }
        public string OperatingSystem { get; set; }

        public void PrintSpecs()
        {
            Console.WriteLine("Processor: " + Processor);
            Console.WriteLine("RAM: " + RAM + " GB");
            Console.WriteLine("Storage: " + Storage + " GB");
            Console.WriteLine("Graphics Card: " + (HasGraphicsCard ? "Yes" : "No"));
            Console.WriteLine("OS: " + OperatingSystem);
        }

    }
}
