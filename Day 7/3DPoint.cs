using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7
{
    class _3DPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public _3DPoint() : this(0, 0, 0) { }

        public _3DPoint(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public void Display()
        {
            Console.WriteLine($"Point Cordinates: ({X}, {Y}, {Z})");
        }

        public void ChangeCoordinates(int newX, int newY, int newZ)
        {
            X = newX;
            Y = newY;
            Z = newZ;
        }

        public override bool Equals(object? obj)
        {
            // p1.Equals(p2)
            if (obj is _3DPoint p) 
            {
                return this.X == p.X && this.Y == p.Y && this.Z == p.Z;
            }
            return false;
        }


        public static bool operator ==(_3DPoint p1 , _3DPoint p2)
        {
            // Now i will implement Equal Function
            return p1.Equals(p2);
        }

        public static bool operator !=(_3DPoint p1, _3DPoint p2)
        {
            
            return !p1.Equals(p2);
        }
    }
}
