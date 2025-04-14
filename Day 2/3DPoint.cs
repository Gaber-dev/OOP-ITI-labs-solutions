using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    public class _3DPoint
    {
        private int X;
        private int Y;
        private int Z;

        public _3DPoint():this(0,0,0) // Default
        {
            
        }

        public _3DPoint(int x , int y ):this( x , y , 0 ) 
        {
            
        }

        
        public _3DPoint(int x, int y , int z )
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

        
    }
}
