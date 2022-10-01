using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    [Color(ConsoleColor.Yellow)]
    public class Square : Shape
    {
        public Square(char symbol, int pointX, int pointY, int side) : base(symbol, pointX, pointY, side)
        {
        }
        public override void Print(Action<string> inputS, Action<char> inputC, Action repeat)
        {
 
            for (int i = 0; i < Side; i++)
            {
                Console.SetCursorPosition(PointY, PointX);
                for (int j = 0; j < Side; j++)
                {
                    if (i == 0 || i == Side - 1)
                    {
                        inputC(Symbol);
                    }
                    else
                    {
                        if (j == 0 || j == Side - 1)
                        {
                            inputC(Symbol);
                        }
                        else
                        {
                            inputS(" ");
                        }
                    }
                }
                inputS("\n");
                PointX++;
            }
            Console.ResetColor();
            repeat();
        }
    }
}
