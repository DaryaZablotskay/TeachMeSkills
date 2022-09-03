using System;
using System.Collections.Generic;
using System.Text;

namespace Section4
{
    static class Task9
    {
        public static void Solve()
        {
            int x = EnterCoordinate();
            int y = EnterCoordinate();
            QuadrantCoordinate(x, y);
        }
        static int EnterCoordinate()
        {
            Console.WriteLine("Enter coordinate");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void QuadrantCoordinate(int x, int y)
        {
            if (x>0 && y>0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the 1 quadrant");
            }
            else if (x<0 && y>0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the 2 quadrant");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the 3 quadrant");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the 4 quadrant");
            }
        }
    }

}
