using System;
using System.Collections.Generic;
using System.Text;

namespace Section4
{
    static class Task8
    {
        public static void Solve()
        {
            int a = EnterNumber();
            int b = EnterNumber();
            int c = EnterNumber();
            MaxNumber(a, b, c);
        }
        static int EnterNumber()
        {
            Console.WriteLine("Enter number");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void MaxNumber(int a, int b, int c)
        {
            if (a>=b && a>=c)
            {
                Console.WriteLine($"max = {a}");
            }
            else if (b>=a && b>=c)
            {
                Console.WriteLine($"max = {b}");
            }
            else if (c>=b && c>=a)
            {
                Console.WriteLine($"max = {c}");
            }
        }
    }

}
