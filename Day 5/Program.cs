namespace Day_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Lab 1  => == operator overloading
            _3DPoint d = new _3DPoint(); // 0 , 0 , 0
            d.Display();

            _3DPoint d1 = new _3DPoint(0, 0, 0); // 0 , 0 , 0
            d1.Display();

            if (d == d1)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }

            // lab 2 => +operator overloading
            Fraction f1 = new Fraction();
            f1.Display();

            Fraction f2 = new Fraction(5);
            f2.Display();

            Fraction f3 = f1 + f2;
            f3.Display();

            
            // implicit operator
            f1 = 5;
            f1.Display(); // 5/5

            // Explicit operator
            int x = (int)f2;
            Console.WriteLine(x); // 5


        }
    }
}
