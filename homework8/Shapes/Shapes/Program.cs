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

            switch (shape)
            {
                case "square":
                    SquarePrint(pointX, pointY);
                    break;
                case "rectangle":
                    RectanglePrint(pointX, pointY);
                    break;
                case "circle":
                    CirclePrint(pointX, pointY);
                    break;
                case "triangle":
                    TrianglePrint(pointX, pointY);
                    break;
                case "text":
                    TextPrint(pointX, pointY);
                    break;
                default:
                    Console.WriteLine("This is not on the list");
                    break;
            }
        }
        static void SquarePrint(int pointX, int pointY)
        {
            Console.WriteLine("Enter the symbol that you will use to draw the shape:");
            var symbol = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the length of the side of the square:");
            var side = Convert.ToInt32(Console.ReadLine());
            if (pointX > 20)
            {
                var square = new Square(symbol, pointX, pointY, side);
                square.Print();
            }
            else
                Console.WriteLine("Not enough space!");
        }
        static void RectanglePrint(int pointX, int pointY)
        {
            Console.WriteLine("Enter the symbol that you will use to draw the shape:");
            var symbol = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the length of the side X of the rectangle:");
            var sideX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the length of the side Y of the rectangle:");
            var sideY = Convert.ToInt32(Console.ReadLine());
            if (pointX > 20)
            {
                var rectangle = new Rectangle(symbol, pointX, pointY, sideX, sideY);
                rectangle.Print();
            }
            else
                Console.WriteLine("Not enough space!");
        }
        static void CirclePrint(int pointX, int pointY)
        {
            Console.WriteLine("Enter the symbol that you will use to draw the shape:");
            var symbol = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the radius of the circle:");
            var radius = Convert.ToInt32(Console.ReadLine());
            if (pointX > 20 + radius && pointY > radius)
            {
                var circle = new Circle(symbol, pointX, pointY, radius);
                circle.Print();
            }
            else
                Console.WriteLine("Not enough space!");
        }
        static void TrianglePrint(int pointX, int pointY)
        {
            Console.WriteLine("Enter the symbol that you will use to draw the shape:");
            var symbol = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the height of the triangle:");
            var height = Convert.ToInt32(Console.ReadLine());
            if (pointX > 20)
            {
                var triangle = new Triangle(symbol, pointX, pointY, height);
                triangle.Print();
            }
            else
                Console.WriteLine("Not enough space!");
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
