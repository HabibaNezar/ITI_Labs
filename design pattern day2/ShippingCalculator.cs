using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_day2
{
    public class ShippingCalculator
    {
        private IShippingStrategy _shippingStrategy;

        public ShippingCalculator(IShippingStrategy shippingStrategy)
        {
            _shippingStrategy = shippingStrategy;
        }

        public decimal Calculate(double weight)
        {
            return _shippingStrategy.CalculateCost(weight);
        }
    }
}
