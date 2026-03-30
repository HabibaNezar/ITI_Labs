namespace design_pattern_day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight = 3;

            // Standard
            ShippingCalculator standard =
                new ShippingCalculator(new StandardShipping());

            Console.WriteLine("Package weight: 3 kg");
            Console.WriteLine("Selected: Standard Shipping");
            Console.WriteLine("Total cost: " + standard.Calculate(weight) + " EGP");

            Console.WriteLine();

            // Express
            ShippingCalculator express =
                new ShippingCalculator(new ExpressShipping());

            Console.WriteLine("Package weight: 3 kg");
            Console.WriteLine("Selected: Express Shipping");
            Console.WriteLine("Total cost: " + express.Calculate(weight) + " EGP");

            Console.WriteLine();

            // International
            ShippingCalculator international =
                new ShippingCalculator(new InternationalShipping());

            Console.WriteLine("Package weight: 3 kg");
            Console.WriteLine("Selected: International Shipping");
            Console.WriteLine("Total cost: " + international.Calculate(weight) + " EGP");
        }
    }
}
