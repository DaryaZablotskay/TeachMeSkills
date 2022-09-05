using System;
using System.Collections.Generic;
using System.Text;

namespace Section2
{
    static class Task42
    {
        public static void Solve()
        {
            int a = EnterNumber();
            CheckMultiple(a);
        }
        static int EnterNumber()
        {
            Console.WriteLine("Enter number");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void CheckMultiple(int a)
        {
            bool check;
            check = (a % 13 == 0 || (a - 1) % 13 == 0);
            Console.WriteLine(check);
        }
    }
}
