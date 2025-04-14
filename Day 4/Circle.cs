using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    class Circle : Shape
    {
        protected double Hal { get; set; }
        public Circle(double H)
        {
            Hal = H;
        }

        public override double CalculateArea()
        {
            return Hal * Hal * 3.14;
        }

    }
}
