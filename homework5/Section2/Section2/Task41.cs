using System;
using System.Collections.Generic;
using System.Text;

namespace Section2
{
    static class Task41
    {
        public static void Solve()
        {
            int a = EnterNumber();
            int b = EnterNumber();
            CheckNumber(a, b);
        }
        static int EnterNumber()
        {
            Console.WriteLine("Enter number");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void CheckNumber(int a, int b)
        {
            bool check;
            check = (a == 5 || b == 5 || a + b == 5 || Math.Abs(a - b) == 5);
            Console.WriteLine(check);
        }
    }
}
