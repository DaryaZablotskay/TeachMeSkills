using System;
using System.Collections.Generic;
using System.Text;

namespace lesson9
{
    public class Square : Shape
    {
        public readonly int _lenthSide;
        public Square(string form, char simvol, int x, int y, int lenth) : base(form, simvol, x, y)
        {
            _lenthSide = lenth;
        }
        public override void Print()
        {
            Console.SetCursorPosition(PointY, PointX);
            for (int i = PointX; i < _lenthSide + PointX; i++)
            {
                for (int j = PointY; j < _lenthSide + PointY; j++)
                {
                    if (i == PointX || i == _lenthSide - 1 + PointX)
                    {
                        Console.Write(_simvol);
                    }
                    else
                    {
                        if (j == PointY || j == _lenthSide + PointY - 1)
                        {
                            Console.Write(_simvol);
                        }
                        else
                        {
                            Console.Write($" ");
                        }
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
