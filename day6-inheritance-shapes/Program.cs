using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6_inheritance_shapes
{
    internal class Program
    {
        public static void RunAllDraw(Shape[] shapes)
        {
            Console.WriteLine("--- Draw all shapes ---");
            foreach(Shape shape in shapes)
            {
                shape.Draw();
            }         
        }
        public static void CalculateAllAreas(Shape[] shapes)
        {
            Console.WriteLine("--- CalCulate All Areas ___");
            foreach(Shape shape in shapes)
            {
                Console.WriteLine(shape.CalcArea()); ;
            }
        }
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]
            {
                new Circle(5, "red"),
                new Rectangle(5,2,"blue"),
                new Square(5,"green"),
                new Triangle(2,4,5,"purple")
            };

            RunAllDraw(shapes);
            Console.WriteLine();
            CalculateAllAreas(shapes);

        }
    }
}
