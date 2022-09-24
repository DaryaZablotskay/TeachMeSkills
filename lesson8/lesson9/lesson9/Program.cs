using System;

namespace lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Which shape do you want to print?");

            //var shape = new Square("square", '+', 2, 4, 6);
            //shape.Print();
            var cir = new Circle(5, "square", '+', 10, 10);
            cir.Print();
        }
    }
}
