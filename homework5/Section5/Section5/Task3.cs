using System;
using System.Collections.Generic;
using System.Text;

namespace Section5
{
    static class Task3
    {
        public static void Solve()
        {
            int n = EnterNumber();
            Sum(n);
        }
        static int EnterNumber()
        {
            Console.WriteLine("Enter number");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void Sum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine($"sum = {sum}");
        }
    }
}
