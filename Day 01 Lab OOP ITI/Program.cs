namespace Day_01_Lab_OOP_ITI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 
           _3DPoint point1 = new _3DPoint(5 , 7 , 8);
           _3DPoint point2 = new _3DPoint(2, 3, 4);
            point1.Display();
            point2.Display();

            int res = _3DPoint.CalculateDistance(point1, point2);
            Console.WriteLine($"Distance Between point 1 and point 2 = {res}");

            Console.WriteLine("---------------------------------");

            // Task 2
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(3, 4);
            f1.Display();
            f2.Display();

            Fraction sum = Fraction.Add(f1, f2); 
            sum.Display();
        }
    }
}
