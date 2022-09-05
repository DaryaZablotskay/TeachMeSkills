using System;
using System.Collections.Generic;
using System.Text;

namespace Section9
{
    static class Task7
    {
        public static void Solve()
        {
            Console.WriteLine("Enter a number");
            int a = EnterNumber();
            Console.WriteLine("Enter exponent");
            int b = EnterNumber();
            PowNumber(a, b);
        }
        static int EnterNumber()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        static void PowNumber(int a, int b)
        {
            Console.WriteLine($"So {a} ^ {b} = {Math.Pow(a, b)}");
        }

    }
}
