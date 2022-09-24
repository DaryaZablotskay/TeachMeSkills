using System;
using System.Collections.Generic;
using System.Text;

namespace lesson9
{
    public abstract class Shape
    {
        public readonly string _form;
        public readonly char _simvol;
        public int PointX { get; set; }
        public int PointY { get; set; }
        public Shape(string form, char simvol, int x, int y)
        {
            _form = form;
            _simvol = simvol;
            PointX = x;
            PointY = y;
        }
        public abstract void Print();

    }
}
