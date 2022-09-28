using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        public Circle(char symbol, int pointX, int pointY, int side) : base(symbol, pointX, pointY, side)
        {
        }
        public override void Print()
        {
            for (int i = Side; i >= -Side; i--)
            {
                Console.SetCursorPosition(PointY, PointX);
                for (int j = Side; j >= -Side; j--)
                {
                    if (Convert.ToInt32(Math.Sqrt(Math.Pow(i, 2) + Math.Pow(j, 2))) == Side)
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
