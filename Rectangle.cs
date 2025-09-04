using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class Rectangle
    {
       protected Line l1;
       protected Line l2;

        public Rectangle()
        {

        }


        public Rectangle(Line lin1 , Line lin2)
        {
            l1 = lin1;
            l2 = lin2;
        }

        public int GetLength()
        {
            return l1.GetLength();
        }

        public int GetWidth()
        {
            return l2.GetLength();
        }

        public int GetArea()
        {
            return l1.GetLength() * l2.GetLength();
        }
    }
}
