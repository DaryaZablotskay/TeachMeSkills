using System;
using System.Collections.Generic;
using System.Text;

namespace Section5
{
    static class Task8
    {
        public static void Solve()
        {
            int n = EnterNumber();
            OddNumber(n);
        }
        static int EnterNumber()
        {
            Console.WriteLine("Enter number");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void OddNumber(int n)
        {
            int sum = 0;
            for (int i=1; i<=n; i++)
            {
                Console.Write($"{2 * i - 1} ");
                sum += (2 * i - 1);
            }
            Console.WriteLine();
            Console.WriteLine($"sum = {sum}");
        }
       

    }
}
