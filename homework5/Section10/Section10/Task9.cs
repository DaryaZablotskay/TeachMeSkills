using System;
using System.Collections.Generic;
using System.Text;

namespace Section10
{
    static class Task9
    {
        public static void Solve()
        {
            int a = Int32.MaxValue;
            int b = Int32.MaxValue;
            Console.WriteLine("Calculate the product of two Int32 values:");
            ProductTwoNumbers(a, b);
        }
        static void ProductTwoNumbers(int a, int b)
        {
            Console.WriteLine($"{a}*{b}={Math.BigMul(a, b)}");
        }

    }
}
