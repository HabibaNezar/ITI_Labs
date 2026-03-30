using System;

namespace PointApp
{
    // 8a. Declare Point struct
    public class Point
    //public struct Point
    {
        // Fields
        private int x;
        private int y;

        // 8b. Properties to set and get values
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        // 8c. Constructor
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // 8d. Print method
        public void Print()
        {
            Console.WriteLine($"({X} , {Y})");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 9. Declare two variables p1, p2 and receive values from the user
            Console.WriteLine("Enter X for p1:");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y for p1:");
            int y1 = int.Parse(Console.ReadLine());
            Point p1 = new Point(x1, y1);

            Console.WriteLine("Enter X for p2:");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y for p2:");
            int y2 = int.Parse(Console.ReadLine());
            Point p2 = new Point(x2, y2);

            Console.Write("p1 is: ");
            p1.Print();

            Console.Write("p2 is: ");
            p2.Print();

            // 10. Trying to compare p1 and p2 (See explanation below)
            bool isEqual = (p1 == p2);
            Console.WriteLine(isEqual);
        }
    }
}