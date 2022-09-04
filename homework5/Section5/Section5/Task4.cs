using System;
using System.Collections.Generic;
using System.Text;

namespace Section5
{
    static class Task4
    {
        public static void Solve()
        {
            int n = 10;
            Sum(n);
        }
        static void Sum(int n)
        {
            int a;
            int sum = 0;
            double aver;
            for(int i=1; i<=n; i++)
            {
                a = Convert.ToInt32(Console.ReadLine());
                sum += a;
            }
            aver = sum / n;
            Console.WriteLine($"sum is {sum}");
            Console.WriteLine($"average is {aver}");
        }
    }
}
