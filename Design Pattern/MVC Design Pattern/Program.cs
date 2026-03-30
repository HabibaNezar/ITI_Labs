using MVC_Design_Pattern.Controllers;

namespace MVC_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentController controller = new StudentController();

            controller.Create();
            controller.Create();

            Console.WriteLine("\nAll Students:");
            controller.Index();

            Console.WriteLine("\nEnter student id to view details:");
            int id = int.Parse(Console.ReadLine());

            controller.Details(id);
        }
    }
}
