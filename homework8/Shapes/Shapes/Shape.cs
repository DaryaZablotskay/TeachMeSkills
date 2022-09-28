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
        public int Side { get; }
        
        public Shape(char symbol, int pointX, int pointY, int side)
        {
            Symbol = symbol;
            PointX = pointX;
            PointY = pointY;
            Side = side;
        }
        public abstract void Print();
    }
}
