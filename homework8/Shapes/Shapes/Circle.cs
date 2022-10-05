using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    [Color(ConsoleColor.Green)]
    public class Circle : Shape
    {
        public Circle(char symbol, int pointX, int pointY, int side) : base(symbol, pointX, pointY, side)
        {
        }
        public override void Print(Action<string> inputS, Action<char> inputC)
        {
            for (int i = Side; i >= -Side; i--)
            {
                Console.SetCursorPosition(PointY, PointX);
                for (int j = Side; j >= -Side; j--)
                {
                    if (Convert.ToInt32(Math.Sqrt(Math.Pow(i, 2) + Math.Pow(j, 2))) == Side)
                    {
                        inputC(Symbol);
                    }
                    else
                    {
                        inputS(" ");
                    }
                }
                inputS("\n");
                PointX++;
            }
            OnNotify();
        }
        protected override void OnNotify()
        {
            base.OnNotify();
        }
    }
}
