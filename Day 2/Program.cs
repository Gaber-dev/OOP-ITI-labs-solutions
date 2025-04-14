namespace Day_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _3DPoint d = new _3DPoint(); // 0 , 0 , 0
            d.Display();

            _3DPoint d1 = new _3DPoint(5, 3, 0);
            d1.Display();

            _3DPoint d2 = new _3DPoint(2, 3, 5);

            Console.WriteLine($"Distance between x of Point1 and x of point2 is {_3DPoint.CalculateDistance(d2, d1)}");
            Console.WriteLine("---------------------------------------------------------");

            Fraction f1 = new Fraction();
            f1.Display();

            Fraction f2 = new Fraction(5);
            f2.Display();

            Fraction f3 = new Fraction(5 , 2);
            f3.Display();

            Fraction Res = Fraction.Add(f3 , f2 );
            Res.Display();



        }
    }
}
