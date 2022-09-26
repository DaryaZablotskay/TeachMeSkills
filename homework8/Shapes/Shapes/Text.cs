using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Text:IPrintable
    {
        public int PointX { get; set; }
        public int PointY { get; set; }
        public string Message { get; set; }
        public Text(string message, int pointX, int pointY)
        {
            Message = message;
            PointX = pointX;
            PointY = pointY;
        }
        public void Print()
        {
            Console.SetCursorPosition(PointY, PointX);
            Console.WriteLine(Message);
        }
    }
}
