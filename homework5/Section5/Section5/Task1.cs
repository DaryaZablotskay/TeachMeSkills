using System;
using System.Collections.Generic;
using System.Text;

namespace Section5
{
    static class Task1
    {
        public static void Solve()
        {
            int n = 10;
            Cycle(n);
        }
        static void Cycle(int n)
        {
            for (int i=1; i<=n; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
