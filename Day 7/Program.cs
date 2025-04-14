using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Dynamic;
using System.Threading.Channels;
namespace Day_7
{
    class Program
    {
       // Write a function that takes a string as input and changes its value.Try to display the original string
       // after calling the function, Does it change?

        public static void ChangesString(ref string s)
        {
            s = "New";
        }


        static void Main(string[] args)
        {
            // Lab 1
            Employee e = new Employee("Gaber Mohamed", 12000);
            e.AssignRole(Role.Admin);
            e.AssignRole(Role.Accountant);
            e.Display();
            Console.WriteLine(e.HasRole(Role.Admin)); // True

            // Lab 2 
            _3DPoint p1 = new _3DPoint(1, 1, 1);
            _3DPoint p2 = new _3DPoint(2 , 2 , 2);
            p1.Display();
            p2.Display();
            Console.Write($"Before Changes : Are Two points Equals  : ");
            Console.Write(p1 == p2);


            p2.ChangeCoordinates(1, 1, 1);
            p1.Display();
            p2.Display();
            Console.Write($"After Changes : Are Two points Equals  : ");
            Console.WriteLine(p1 == p2);




            // Lab 3 
            string OriginalString = "Old";
            Console.WriteLine($"Before Changing Old value : Old value is {OriginalString}");
            ChangesString(ref OriginalString); // For changing original value not copy a var from it 
            Console.WriteLine($"After Changing Old value : Old value is =>  {OriginalString}");
        }
    }
}
