using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    [Color(ConsoleColor.Red)]
    public class Text:IPrintable
    {
        public delegate void Menu();
        public event Menu? Notify;
        public int PointX { get; set; }
        public int PointY { get; set; }
        public string Message { get; set; }
        public Text(string message, int pointX, int pointY)
        {
            Message = message;
            PointX = pointX;
            PointY = pointY;
        }
        public void Print(Action<string> inputS, Action<char> inputC)
        {
            Console.SetCursorPosition(PointY, PointX);
            inputS(Message);
            inputS("\n");
            Notify?.Invoke();
        }
    }
}
