using System;
using System.Collections.Generic;
using System.Text;

namespace tasks
{
    static class Problem1
    {
        public static void Solve()
        {
            int a = Peremen();
            int b = Peremen();
            Sum(a, b);

        }
        static int Peremen()
        {
            Console.WriteLine("Enter number");
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        static void Sum(int a, int b)
        {
            if(a==b)
            {
                Console.WriteLine($"sum=3*({a}+{b})={3*(a + b)}");
            }
            else
            {
                Console.WriteLine($"sum={a}+{b}={a + b}");
            }
            
        }
    }
}
