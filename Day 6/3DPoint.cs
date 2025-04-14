using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    class _3DPoint
    {
        private int X;
        private int Y;
        private int Z;

        public _3DPoint() : this(0, 0, 0) // Default
        {

        }

        public _3DPoint(int x, int y) : this(x, y, 0)
        {

        }


        public _3DPoint(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public void Display()
        {
            Console.WriteLine($"X = {X} , Y = {Y} , Z = {Z}");
        }



        public static int CalculateDistance(_3DPoint p1, _3DPoint p2) // x , y , z  => Class.MethodName
        {
            return Math.Abs(p1.X - p2.X);
        }



        public override bool Equals(object? obj)
        {
            //  _3DPoint d1 = new _3DPoint(5, 3, 0);
            if (obj is _3DPoint)
            {
               _3DPoint h =  (_3DPoint)obj; 
                return this.X == h.X;
            }
            else
            {
                return false;
            }

        }

        public override string ToString()
        {
            return $"X = {X} and Y = {Y} and Z = {Z}";
        }

        public static  bool operator ==(_3DPoint p1 , _3DPoint p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z;
        }


        public static bool operator !=(_3DPoint p1, _3DPoint p2)
        {
            return p1.X != p2.X || p1.Y != p2.Y || p1.Z != p2.Z;
        }

        public void Display(_3DPoint[] arr)
        {
            for(int i = 0; i<arr.Length; i++)
            {
                Display();
            }
        }
    }
}
