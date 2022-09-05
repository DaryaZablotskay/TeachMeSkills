using System;
using System.Collections.Generic;
using System.Text;

namespace Section2
{
    static class Task15
    {
        public static void Solve()
        {
            Console.WriteLine("check diapazon 20...50");
            int a = EnterNumber();
            int b = EnterNumber();
            int c = EnterNumber();
            CheckDiapozon(a, b, c);
        }
        static int EnterNumber()
        {
            Console.WriteLine("Enter number");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void CheckDiapozon(int a, int b, int c)
        {
            bool check;
            check = ((a >= 20 && a <= 50) || (b >= 20 && b <= 50) || (c >= 20 && c <= 50));
            Console.WriteLine(check);
        }
    }
}
