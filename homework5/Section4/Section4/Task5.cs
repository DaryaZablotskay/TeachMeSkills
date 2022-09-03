using System;
using System.Collections.Generic;
using System.Text;

namespace Section4
{
    static class Task5
    {
        public static void Solve()
        {
            int a = EnterYear();
            CheckYear(a);
        }
        static int EnterYear()
        {
            Console.WriteLine("Enter year");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void CheckYear(int a)
        {
            if (a>=18)
            {
                Console.WriteLine("Congratulation! You are eligible for casting your vote.");
            }
            else
            {
                Console.WriteLine("Ops! You aren't eligible for casting your vote.");
            }
        }
    }
}
