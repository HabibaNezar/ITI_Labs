using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Design_Pattern
{
    // depend on interface instead of classes
    internal interface ITaxService
    {
        // method return amount after calculate tax
        double calculateTax(double amount);
        
    }
}
