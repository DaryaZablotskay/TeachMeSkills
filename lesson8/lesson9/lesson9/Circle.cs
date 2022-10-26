using System;
using System.Collections.Generic;
using System.Text;

namespace lesson9
{
    public class Circle : Shape
    {
        public int Diametr { get; set; }
        public Circle(int diametr, string form, char simvol, int x, int y) : base(form, simvol, x, y)
        {
            Diametr = diametr;
        }
        public override void Print()
        {
            //char[,] circle = new char[100,100];
            
            for (int i=0; i<Diametr; i++)
            {
                Console.SetCursorPosition(PointY, PointX);
                for (int j=0; j<Diametr;j++)
                {
                    Console.Write(_simvol);
                }
                Console.WriteLine();
                PointX++;
            }
        }
    }
}
