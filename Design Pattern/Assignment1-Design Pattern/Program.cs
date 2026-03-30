namespace Assignment1_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // dependancy inversion ==> high level class doesnt depend on low level class and both depend on interface
            // dependancy injection ==> injection constructor depend on this interface

            double subtotal = 1000;
            ITaxService egyptTax = new EgyptTaxService();
            InvoiceService egyptInvoice = new InvoiceService(egyptTax);

            ITaxService saudiTax = new SaudiTaxService();
            InvoiceService saudiInvoice = new InvoiceService(saudiTax);

            Console.WriteLine("--- Egypt Tax System --- ");
            egyptInvoice.CalculateInvoice(subtotal, "EGP");

            Console.WriteLine("--- Saudi Tax System --- ");
            saudiInvoice.CalculateInvoice(subtotal, "EGP");


        }
    }
}
