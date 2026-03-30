using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class PrinterManager
    {
        // singlton => prevent to make more than one instance
        // three steps => 1-static instance, 2-private constructor, 3-method to return the same instance
        
        // 1- static private instance 
        private static PrinterManager instance;

        // 2- private constructor
        private PrinterManager() 
        {
            Console.WriteLine("printer initialized");
        }

        // 3- method to return the same instance
        public static PrinterManager GetInstance()
        {
            if (instance == null)
            {
                instance = new PrinterManager();
            }

            return instance;
        }

        int printingCount = 0;
        public void PrintDoc(string docName) 
        {
            printingCount++;
            Console.WriteLine($"Printing: {docName} (Total printed: {printingCount})");
        }

    }
}
