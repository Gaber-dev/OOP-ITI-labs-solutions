using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class _2DPoint
    {
        private int X;
        private int Y;

        public _2DPoint(int x , int y)
        {
            X = x;
            Y = y;
        }

        public int GetX()
        {
            return X;
        }

        public int GetY()
        {
            return Y;
        }

        public void GetPointfullDetails()
        {
            Console.WriteLine($"X = {X} and Y = {Y}");
        }
    }
}
