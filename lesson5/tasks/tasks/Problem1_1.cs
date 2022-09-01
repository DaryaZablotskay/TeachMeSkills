using System;
using System.Collections.Generic;
using System.Text;

namespace tasks
{
    static class Problem1_1
    {
        public static void Solve()
        {
            int a = Number();
            int b = Number();
            Sravnenie(a, b);
        }
        static int Number()
        {
            Console.WriteLine("Enter number");
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        static void Sravnenie(int a, int b)
        {
            if (a==b)
            {
                Console.WriteLine($"{a} and {b} are equal");
            }
            else
            {
                Console.WriteLine($"{a} and {b} are not equal");
            }
        }
    }
}
