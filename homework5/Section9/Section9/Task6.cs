using System;
using System.Collections.Generic;
using System.Text;

namespace Section9
{
    static class Task6
    {
        public static void Solve()
        {
            int a = EnterNumber();
            int b = EnterNumber();
            SwapNumber(a, b);
        }
        static int EnterNumber()
        {
            Console.WriteLine("Enter a number");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void SwapNumber(int a, int b)
        {
            int saveA = a;
            a = b;
            b = saveA;
            Console.WriteLine($"Now the 1st number is : {a} , and the 2nd number is : {b}");

        }

    }
}
