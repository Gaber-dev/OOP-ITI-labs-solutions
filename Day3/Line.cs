using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class Line
    {
        _2DPoint point1;
        _2DPoint point2;

        public Line(int _p1x, int _p1y, int _p2x, int _p2y)
        {
            point1 = new _2DPoint(_p1x, _p1y);
            point2 = new _2DPoint(_p2x, _p2y);
        }


        public int GetLength()
        {
            return Convert.ToInt32( Math.Sqrt(Math.Pow((point1.GetX() - point2.GetX()), 2) + Math.Pow((point1.GetY() - point2.GetY()), 2)));
        } 
    }
}
