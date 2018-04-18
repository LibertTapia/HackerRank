using OOP.Abstract;
using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Shape[] shapes = { new Circle(5), new Rectangle(4, 5) };
            foreach(Shape s in shapes)
            {
                s.GetInfo();
                Console.WriteLine("{0} Area : {1:f2}", s.Name, s.Area());
                Circle testCirc = s as Circle;
                if(testCirc == null)
                {
                    Console.WriteLine("This isn't a Circle");
                }
                else if(testCirc is Circle)
                {
                    Console.WriteLine("This isn't a Rectangle");
                }
                Console.WriteLine();

                object circ1 = new Circle(4);
                Circle circ2 = (Circle)circ1;

                Console.WriteLine($"The {circ2.Name} Area is {circ2.Area():f2}");
            }
            Console.ReadLine();
        }
    }
}
