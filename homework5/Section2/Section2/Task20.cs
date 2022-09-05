using System;
using System.Collections.Generic;
using System.Text;

namespace Section2
{
    static class Task20
    {
        public static void Solve()
        {
            Console.WriteLine("check diapaxon 40...50 or 50...60");
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
            check = (((a >= 40 && a <= 50) && (b >= 40 && b <= 50))
                || ((a >= 50 && a <= 60) && (b >= 50 && b <= 60)));
            Console.WriteLine(check);
        }
    }
}
