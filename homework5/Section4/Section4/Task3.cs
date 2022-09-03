using System;
using System.Collections.Generic;
using System.Text;

namespace Section4
{
    static class Task3
    {
        public static void Solve()
        {
            int a = EnterNumber();
            CheckPositive(a);
        }
        static int EnterNumber()
        {
            Console.WriteLine("Enter number");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void CheckPositive(int a)
        {
            if (a>0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }
        }
    }
}
