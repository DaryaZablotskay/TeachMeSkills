using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public abstract class Shape : IPrintable
    {
        public char Symbol { get; }
        public int PointX { get; set; }
        public int PointY { get; set; }
        
        public Shape(char symbol, int pointX, int pointY)
        {
            Symbol = symbol;
            PointX = pointX;
            PointY = pointY;
        }
        public abstract void Print();
    }
}
