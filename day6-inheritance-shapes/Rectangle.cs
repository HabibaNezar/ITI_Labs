using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6_inheritance_shapes
{
    internal class Rectangle:Shape
    {
        // fields
        double d1;
        double d2;

        // properties
        public double D1 {
            get
            {
                return d1;
            } 
            set
            {
                d1 = value;
            }
        }

        public double D2
        {
            get
            {
                return d2;
            }
            set
            {
                d2 = value;
            }
        }


        // constructor
        public Rectangle (double initialD1 ,double initialD2, string initialColor) : base(initialColor)
        {
            d1 = initialD1;
            d2 = initialD2;
        }

        // methods
        public override double CalcArea()
        {
            return d1 * d2;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing Rectangle, Color: {Color}, Width: {d1}, Height: {d2}");
        }

    }
}
