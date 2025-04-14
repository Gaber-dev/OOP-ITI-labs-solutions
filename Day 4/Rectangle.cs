using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    class Rectangle : Shape
    {
        protected double Hight { get; set; }
        protected double Width { get; set; }

        public Rectangle(double hight , double width)
        {
            Hight = hight;
            Width = width;
        }

        public override double CalculateArea()
        {
            return Hight * Width;
        }
    }
}
