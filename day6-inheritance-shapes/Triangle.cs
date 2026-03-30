using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6_inheritance_shapes
{
    internal class Triangle:Shape
    {
        //fields
        double d1;
        double d2;
        double d3;

        // properties
        
        public double D1
        {
            get { return d1; }
            set { d1 = value; }
        }

        public double D2
        {
            get { return d2; }
            set { d2 = value; }
        }

        public double D3
        {
            get { return d3; }
            set { d3 = value; }
        }


        // consetructor 
        public Triangle(double a, double b, double c, string color ):base(color)
        {
            d1 = a;
            d2 = b;
            d3 = c;
        }

        // methods
        public override double CalcArea()
        {
            double s = (d1 + d2 + d3) / 2;
            return Math.Sqrt(s * (s - d1) * (s - d2) * (s - d3));
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing Triangle, Color: {Color}, Sides: {d1}, {d2}, {d3}");
        }


    }
}
