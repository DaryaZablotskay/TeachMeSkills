using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    [Color(ConsoleColor.Blue)]
    public class Triangle:Shape
    {
        public Triangle(char symbol, int pointX, int pointY, int side) : base(symbol, pointX, pointY, side)
        {
        }
        public override void Print(Action<string> inputS, Action<char> inputC, Action repeat)
        {
            for (int i = 0; i < Side; i++)
            {
                Console.SetCursorPosition(PointY + Side - i, PointX + i + 1);
                for (int j = 0; j <= i * 2; j++)
                {
                    if (j == 0 || j == 2 * i || i == Side - 1)
                    {
                        inputC(Symbol);
                    }
                    else
                    {
                        inputS(" ");
                    }
                }
                inputS("\n");
            }
            Console.ResetColor();
            repeat();
        }
    }
}
