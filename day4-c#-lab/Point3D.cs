using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4_c__lab
{
    internal class Point3D:IComparable, ICloneable
    {
        #region properties
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        #endregion

        #region constructor chaining
        public Point3D():this(0){ }
        public Point3D(int x) : this(x, 0, 0) { }
        public Point3D(int x, int y): this(x, y, 0) { }
        public Point3D(int a, int b, int c)
        {
            X = a; 
            Y = b;
            Z = c;
        }
        #endregion

        #region methods
        public override string ToString()
        {
            return $"Point Coordinates: ({X},{Y},{Z})";
        }

        public override bool Equals(object? obj)
        {
            return obj is Point3D other && X == other.X && Y == other.Y && Z == other.Z ;

        }

        public int CompareTo(object? obj)
        {
            if (obj is Point3D other) 
            {
                if (X > other.X && Y > other.Y)
                {
                    return 1;
                }
                else if (X < other.X && Y < other.Y)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            throw new ArgumentException("object is not point 3d");
        }

        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }
        #endregion

    }
}
