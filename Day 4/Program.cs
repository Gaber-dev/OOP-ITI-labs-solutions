namespace Day_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Picture picture = new Picture();

            picture.AddShape(new Rectangle(5, 10));
            picture.AddShape(new Square(4));
            picture.AddShape(new Circle(3));

            picture.DisplayAllShapesArea();


        }
    }
}
