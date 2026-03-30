namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrinterManager printer1 = PrinterManager.GetInstance();
            PrinterManager printer2 = PrinterManager.GetInstance();
            PrinterManager printer3 = PrinterManager.GetInstance();

            printer1.PrintDoc("Report.pdf");
            printer2.PrintDoc("Invoice.docx");
            printer3.PrintDoc("Contract.pdf");

            Console.WriteLine();

            Console.WriteLine("Testing if same instance:");

            Console.WriteLine("printer1 == printer2: " + (printer1 == printer2));
            Console.WriteLine("printer1 == printer3: " + (printer1 == printer3));
        }
    }
}
