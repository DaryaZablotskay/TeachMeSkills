using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a shape: \n" + "square \n" + "circle \n" + "triangle \n" + "rectangle \n" + "text");
            Console.WriteLine();
            var shape = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter the origin of the coordinates by X more than 20:");
            var pointX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the origin of the coordinates by Y:");
            var pointY = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the symbol that you will use to draw the shape:");
            var symbol = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the length of the side of the shape:");
            var side = Convert.ToInt32(Console.ReadLine());

            switch (shape)
            {
                case "square":
                    var square = new Square(symbol, pointX, pointY, side);
                    square.Print();
                    break;
                case "circle":
                    var circle = new Circle(symbol, pointX, pointY, side);
                    circle.Print();
                    break;
                case "triangle":
                    var triangle = new Triangle(symbol, pointX, pointY, side);
                    triangle.Print();
                    break;
                case "text":
                    TextPrint(pointX, pointY);
                    break;
                default:
                    Console.WriteLine("This is not on the list");
                    break;
            }
        }
        static void TextPrint(int pointX, int pointY)
        {
            Console.WriteLine("Enter text");
            var message = Console.ReadLine();
            if (pointX > 20)
            {
                var text = new Text(message, pointX, pointY);
                text.Print();
            }
        }
    }
}
