using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_01_Lab_OOP_ITI
{
    public class _3DPoint
    {
        private int x;
        private int y;
        private int z;

        public _3DPoint(int X  , int Y , int Z)
        {
            x = X;
            y = Y;
            z = Z;
        }

        public void Display()
        {
            Console.WriteLine($"X = {x} , Y = {y} , Z = {z}");
        }

        public static int CalculateDistance(_3DPoint p1 , _3DPoint p2) // x , y , z
        {
            return Math.Abs(p1.x - p2.x);
        }

    }
}
