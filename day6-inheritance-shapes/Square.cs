using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6_inheritance_shapes
{
    internal class Square:Rectangle
    {
        
        // constructors
        public Square (double l , string color) : base(l, l, color)
        {
           
        }
        
        public override void Draw()
        {
            Console.WriteLine($"Drawing Square, Color: {Color}, Side: {D1}");
        }
    }
}
