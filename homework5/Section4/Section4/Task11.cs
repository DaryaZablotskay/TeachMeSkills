using System;
using System.Collections.Generic;
using System.Text;

namespace Section4
{
    static class Task11
    {
        public static void Solve()
        {
            Console.WriteLine("Enter coefficient a");
            int a = EnterСoefficient();
            Console.WriteLine("Enter coefficient b");
            int b = EnterСoefficient();
            Console.WriteLine("Enter coefficient c");
            int c = EnterСoefficient();
            QuadraticEquation(a, b, c);
        }
        static int EnterСoefficient()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        static void QuadraticEquation(int a, int b, int c)
        {
            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D>0)
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"x1={x1}, x2={x2}");
            }
            else if (D==0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"x={x}");
            }
            else if (D<0)
            {
                Console.WriteLine("No Solution!");
            }
            
        }
    }
    
}
