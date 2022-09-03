using System;
using System.Collections.Generic;
using System.Text;

namespace Section5
{
    static class Task6
    {
        public static void Solve()
        {
            int n = 10;
            int a = EnterNumber();
            MultiplicationTable(a, n);
        }
        static int EnterNumber()
        {
            Console.WriteLine("Enter number");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void MultiplicationTable(int a, int n)
        {
            for(int i=1; i<=n; i++)
            {
                Console.WriteLine($"{a} * {i} = {a * i}");
            }
        }
    }
}
