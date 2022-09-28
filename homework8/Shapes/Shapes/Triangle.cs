using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Triangle:Shape
    {
        public Triangle(char symbol, int pointX, int pointY, int side) : base(symbol, pointX, pointY, side)
        {
        }
        public override void Print()
        {
            for (int i = 0; i < Side; i++)
            {
                Console.SetCursorPosition(PointY + Side - i, PointX + i + 1);
                for (int j = 0; j <= i * 2; j++)
                {
                    if (j == 0 || j == 2 * i || i == Side - 1)
                    {
                        Console.Write(Symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
