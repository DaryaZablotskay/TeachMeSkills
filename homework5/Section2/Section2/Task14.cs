using System;
using System.Collections.Generic;
using System.Text;

namespace Section2
{
    static class Task14
    {
        public static void Solve()
        {
            Console.WriteLine("check diapazon 100...200");
            int a = EnterNumber();
            int b = EnterNumber();
            CheckDiapozon(a, b);
        }
        static int EnterNumber()
        {
            Console.WriteLine("Enter number");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void CheckDiapozon(int a, int b)
        {
            bool check;
            check = ((a < 200 && a > 100) || (b < 200 && b > 100));
            Console.WriteLine(check);
        }
    }
}
