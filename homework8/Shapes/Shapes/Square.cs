﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Square : Shape
    {
        public int Side { get; }
        public Square(char symbol, int pointX, int pointY, int side) : base(symbol, pointX, pointY)
        {
            Side = side;
        }
        public override void Print()
        {
            for (int i = 0; i < Side; i++)
            {
                Console.SetCursorPosition(PointY, PointX);
                for (int j = 0; j < Side; j++)
                {
                    if (i == 0 || i == Side - 1)
                    {
                        Console.Write(Symbol);
                    }
                    else
                    {
                        if (j == 0 || j == Side - 1)
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