using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_day2
{
    public class StandardShipping:IShippingStrategy
    {
        public decimal CalculateCost(double weight)
        {
            return 50;
        }
    }
}
