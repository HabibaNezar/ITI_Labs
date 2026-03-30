namespace day4_c__lab
{
    internal class Program
    {
        // array display
        public static void ArrDispay(Point3D[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static Point3D[] ReadPoints()
        {
            //read from user 2 points
           
            Point3D[] p = new Point3D[2];
            for (int i = 0; i < p.Length; i++)
            {
                int x;
                Console.Write($"enter x of the point{i + 1} : ");
                while (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("enter a valid number");
                }
                int y;
                Console.Write($"enter y of the point{i + 1} : ");
                while (!int.TryParse(Console.ReadLine(), out y))
                {
                    Console.WriteLine("enter a valid number");
                }
                int z;
                Console.Write($"enter z of the point{i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out z))
                {
                    Console.WriteLine("enter a valid number");
                }
                p[i] = new Point3D(x, y, z);
                Console.WriteLine();
            }
            ArrDispay(p);
            return p;
        }
        static void Main(string[] args)
        {
            // instanse of the class and test tostring
            Point3D p1 = new Point3D(1, 2, 3);
            Console.WriteLine(p1);
            
           
            
            Point3D[] p = ReadPoints();


            // check equality by == & Equals
            Console.WriteLine($"is p1 == p2     : {p[0] == p[1]}");
            Console.WriteLine($"is p1 Equals p2 : {p[0].Equals(p[1])}");

            // sorting
            Array.Sort(p);
            ArrDispay(p);

            // ICloneable interface
            Point3D p2 = (Point3D)p1.Clone();
            Console.WriteLine(p2);

            Console.WriteLine("Math class ex");
            Console.WriteLine($"addition = {Math.Add(1, 2)}");
        }
    }
}
