using ClassLibrary1;

namespace ConsoleApp1_day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 20;
            Console.WriteLine("Hello, World!");
            Console.WriteLine();

            Class1 myLib = new Class1();
            myLib.print();
            Console.ReadKey();
        }
    }
}
