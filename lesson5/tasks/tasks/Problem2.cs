using System;
using System.Collections.Generic;
using System.Text;

namespace tasks
{
    static class Problem2
    {
        public static void Solve()
        {
            int n = Number();
            AbsoluteDifference(n);
        }
        static int Number()
        {
            Console.WriteLine("Enter number");
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        static void AbsoluteDifference(int n)
        {
            if (n>51)
            {
                Console.WriteLine($"rez=3*({n}-51)={3 * (n - 51)}");
            }
            else
            {
                Console.WriteLine($"rez=51-{n}={51 - n}");
            }
        }
    }
}
