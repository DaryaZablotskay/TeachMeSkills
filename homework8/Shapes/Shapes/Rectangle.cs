using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        public int SideX { get; set; }
        public int SideY { get; set; }
        public Rectangle(char symbol, int pointX, int pointY, int sideX, int sideY) : base(symbol, pointX, pointY)
        {
            SideX = sideX;
            SideY = sideY;
        }
        public override void Print()
        {
            for (int i = 0; i < SideY; i++)
            {
                Console.SetCursorPosition(PointY, PointX);
                for (int j = 0; j < SideX; j++)
                {
                    if (i == 0 || i == SideY - 1)
                    {
                        Console.Write(Symbol);
                    }
                    else
                    {
                        if (j == 0 || j == SideX - 1)
                        {
                            Console.Write(Symbol);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
                PointX++;
            }
        }
    }
}
