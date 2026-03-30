using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Design_Pattern
{
    internal class InvoiceService
    {

        public ITaxService Tax;

        // constructor injection
        public InvoiceService(ITaxService tax)
        {
            Tax = tax;
        }

        // method to calculate invoice
        public void CalculateInvoice(double amount, string currency)
        {
            double tax = Tax.calculateTax(amount);
            double total = amount + tax;

            Console.WriteLine($"Subtotal: { amount} {currency}");
            Console.WriteLine($"Tax: {tax} {currency}");
            Console.WriteLine($"total: {total} {currency}");
        }
    }
}
