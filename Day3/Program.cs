namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //_2DPoint p1 = new _2DPoint(5, 3);
            //_2DPoint p2 = new _2DPoint(10, 3);

            Line line1 = new Line(0, 0, 5, 0);
            Console.WriteLine(line1.GetLength());
            Line line2 = new Line(0, 0, 0, 4);

            Rectangle r1 = new Rectangle(line1, line2);
            Console.WriteLine(r1.GetArea());

            Square s1 = new Square(line1);
            Console.WriteLine(s1.GetArea());
        }
    }
}
