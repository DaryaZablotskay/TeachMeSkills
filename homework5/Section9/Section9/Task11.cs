using System;
using System.Collections.Generic;
using System.Text;

namespace Section9
{
    static class Task11
    {
        public static void Solve()
        {
            int a = EnterNumber();
            int f = Factorial(a);
            Console.WriteLine(f);
        }
        static int EnterNumber()
        {
            Console.WriteLine("Enter a number");
            return Convert.ToInt32(Console.ReadLine());
        }
        static int Factorial(int a)
        {
            if (a == 1)
            {
                return 1;
            }
            else
            {
                return a * Factorial(a - 1);
            }
        }
    }
}
