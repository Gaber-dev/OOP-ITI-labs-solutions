using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class Square : Rectangle
    {
        public Square(Line _l)
        {
            l1 = _l;
            l2 = null;
        }

        public int getLength()
        {
            return l1.GetLength();
        }
        public int GetArea()
        {
            int length = l1.GetLength();
            int area = length * length;

            return area;
        }
    }
}
