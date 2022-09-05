using System;
using System.Collections.Generic;
using System.Text;

namespace Section9
{
    static class Task3
    {
        public static void Solve()
        {
            int a = EnterNumber();
            int b = EnterNumber();
            Sum(a, b);
        }
        static int EnterNumber()
        {
            Console.WriteLine("Enter a number for sum");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void Sum(int a, int b)
        {
            Console.WriteLine($"The sum of two numbers is : {a + b}");
        }
    }
}