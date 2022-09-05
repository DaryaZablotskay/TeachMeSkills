using System;
using System.Collections.Generic;
using System.Text;

namespace Section4
{
    static class Task2
    {
        public static void Solve()
        {
            int a = EnterNumber();
            CheckEven(a);
        }
        static int EnterNumber()
        {
            Console.WriteLine("Enter number");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void CheckEven(int a)
        {
            if (a%2==0)
            {
                Console.WriteLine("even integer");
            }
            else
            {
                Console.WriteLine("odd integer");
            }
        }
    }
}
