using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6_inheritance_shapes
{
    internal class Circle:Shape
    {
        // fields
        double r;

        // properties
        public double R
        {
            get { return r; }
            set { r = value; }
        }


        // costructor
        public Circle(float initialRadius , string initialColor):base(initialColor)
        {
            r = initialRadius;
        }

        // methods
        public override double CalcArea()
        {
            double myArea = Math.PI * r * r;
            return myArea;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing Circle, Color: {Color}, Radius: {r}");
        }
    }
}
