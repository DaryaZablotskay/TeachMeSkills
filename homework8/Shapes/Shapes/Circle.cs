using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        public int Radius { get; set; }
        public Circle(char symbol, int pointX, int pointY, int radius) : base(symbol, pointX, pointY)
        {
            Radius = radius;
        }
        public override void Print()
        {
            for (int i = Radius; i >= -Radius; i--)
            {
                Console.SetCursorPosition(PointY, PointX);
                for (int j = Radius; j >= -Radius; j--)
                {
                    if (Convert.ToInt32(Math.Sqrt(Math.Pow(i, 2) + Math.Pow(j, 2))) == Radius)
                    {
                        Console.Write(Symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                PointX++;
            }
        }
    }
}
