using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6_inheritance_shapes
{
    // abstract class ... can't create object from it, can have abstract method to inforce other inheritance classes to overWrite this abstract method
    internal abstract class Shape
    {
        // fields

        //dynamic properties
        public string Color { get; set; }

        // constructor
        public Shape( string initialColor) { Color = initialColor; }

        // methods

        // abstract methods (no body), inforce inheritance classes to overWrie it
        public abstract double CalcArea();
        public abstract void Draw();
        
    }
}
