using System;
using System.Collections.Generic;
using System.Text;

namespace Section2
{
    static class Task18
    {
        public static void Solve()
        {
            Console.WriteLine("fint max");
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
                Console.WriteLine($"max = { a}");
            }
            else if (b>=a && b>=c)
            {
                Console.WriteLine($"max = { b}");
            }
            else if (c>=a && c>=b)
            {
                Console.WriteLine($"max = { c}");
            }
        }
    }
}
