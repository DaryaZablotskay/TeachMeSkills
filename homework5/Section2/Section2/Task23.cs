using System;
using System.Collections.Generic;
using System.Text;

namespace Section2
{
    static class Task23
    {
        public static void Solve()
        {
            Console.WriteLine("check what number have the same last digit.");
            int a = EnterNumber();
            int b = EnterNumber();
            SameLastDigit(a, b);
        }
        static int EnterNumber()
        {
            Console.WriteLine("Enter number");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void SameLastDigit(int a, int b)
        {
            bool check;
            check = (a % 10 == b % 10);
            Console.WriteLine(check);
        }
    }
}
