namespace Day_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Equal() Use
            //_3DPoint d1 = new _3DPoint(5, 3, 0);
            //d1.Display();

            //_3DPoint d2 = new _3DPoint(5, 3, 5);
            //d2.Display();
            //Console.WriteLine(d1.Equals(d2)); // True

            // Tostring() use
            //_3DPoint d1 = new _3DPoint(5, 3, 0);
            //Console.WriteLine(d1.ToString());


            //  operator overloading use
            //_3DPoint d1 = new _3DPoint(5, 3, 0);
            //_3DPoint d2 = new _3DPoint(5, 3, 0);
            //if(d1 == d2)
            //{
            //    Console.WriteLine("Equal points");
            //}
            //else
            //{
            //    Console.WriteLine("Not Equals Points");
            //}

            //_3DPoint[] points = new _3DPoint[]
            //{
            //    new _3DPoint(5 , 2 , 1),
            //    new _3DPoint (2 , 7 , 6),
            //    new _3DPoint (5 , 2 , 9)

            //};

            //    foreach (_3DPoint point in points)
            //    {
            //        point.Display();
            //    }
            //}

            Person person1 = new Employee
            {
                Name = "Ahmed",
                Age = 30,
                address = new Address { City = "Alexandria", Street = "Corniche", ZipCode = 21500 },
                NID = "12345678901234",
                Salary = 5000.00
            };

            Person person2 = new Trainee
            {
                Name = "Fatima",
                Age = 22,
                address = new Address { City = "Cairo", Street = "Tahrir", ZipCode = 11511 },
                NID = "98765432109876",
                IntakeNumber = 2023
            };

            Person person3 = new Employee
            {
                Name = "Youssef",
                Age = 35,
                address = new Address { City = "Giza", Street = "Pyramids", ZipCode = 12556 },
                NID = "11223344556677",
                Salary = 6000.00
            };

            // Create an array and add objects
            Person[] people = new Person[] { person1, person2, person3 };

            // Display array data
            foreach (Person person in people)
            {
                Console.WriteLine(person.ToString());
            }

            // Demonstrate Clone()
            Person clonedPerson = person1.Clone();
            Console.WriteLine("\nCloned Person:");
            Console.WriteLine(clonedPerson.ToString());
        }
    }
    }

