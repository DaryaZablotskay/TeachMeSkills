using System;
using System.Collections.Generic;
using System.Text;

namespace Section5
{
    static class Task2
    {
        public static void Solve()
        {
            int n = 10;
            Sum(n);
        }
        static void Sum(int n)
        {
            int sum=0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"sum = {sum}");
        }
    }
}
