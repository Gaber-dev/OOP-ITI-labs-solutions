using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    class Picture
    {
        private List<Shape> shapes = new List<Shape>();

        public void AddShape(Shape shape)
        {
            shapes.Add(shape);
        }

        public void DisplayAllShapesArea()
        {
            foreach (var shape in shapes)
            {
                Console.WriteLine($"Shape Area: {shape.CalculateArea()}");
            }
        }
    }
}
