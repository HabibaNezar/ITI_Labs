using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Design_Pattern
{
    internal class SaudiTaxService : ITaxService
    {
        public double calculateTax(double amount)
        {
            return amount*0.15;
        }
    }
}
