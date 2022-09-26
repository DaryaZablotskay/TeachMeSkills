using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Triangle:Shape
    {
        public int Height { get; set; }
        public Triangle(char symbol, int pointX, int pointY, int height) : base(symbol, pointX, pointY)
        {
            Height = height;
        }
        public override void Print()
        {
            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(PointY + Height - i, PointX + i + 1);
                for (int j = 0; j <= i * 2; j++)
                {
                    if (j == 0 || j == 2 * i || i == Height - 1)
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
