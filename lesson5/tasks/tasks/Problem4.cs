using System;
using System.Collections.Generic;
using System.Text;

namespace tasks
{
    static class Problem4
    {
        public static void Solve()
        {
            int a = Number();
            CheckDiapozon(a);
        }
        static int Number()
        {
            Console.WriteLine("Enter number");
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        static void CheckDiapozon(int a)
        {
            bool check= (a >= 90 && a <= 110) || (a >= 190 && a <= 210);
            Console.WriteLine(check);
        }
    }
}
