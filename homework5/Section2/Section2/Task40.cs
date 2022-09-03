using System;
using System.Collections.Generic;
using System.Text;

namespace Section2
{
    static class Task40
    {
        public static void Solve()
        {
            int a = EnterNumber();
            int b = EnterNumber();
            CheckSum(a, b);
        }
        static int EnterNumber()
        {
            Console.WriteLine("Enter number");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void CheckSum(int a, int b)
        {
            int sum = a + b;
            if (sum>=10 && sum<=20)
            {
                Console.WriteLine(30);
            }
            else
            {
                Console.WriteLine(sum);
            }
        }
    }
}
