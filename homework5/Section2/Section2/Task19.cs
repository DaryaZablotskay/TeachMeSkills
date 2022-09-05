using System;
using System.Collections.Generic;
using System.Text;

namespace Section2
{
    static class Task19
    {
        public static void Solve()
        {
            Console.WriteLine("check which number nearest to the value 100");
            int a = EnterNumber();
            int b = EnterNumber();
            CloserToHundred(a, b);
        }
        static int EnterNumber()
        {
            Console.WriteLine("Enter number");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void CloserToHundred(int a, int b)
        {
            if (Math.Abs(100 - a) > Math.Abs(100 - b))
            {
                Console.WriteLine(b);
            }
            else if (Math.Abs(100 - a) < Math.Abs(100 - b))
            {
                Console.WriteLine(a);
            }
            else if (a==b)
            {
                Console.WriteLine(0);
            }
            else if (Math.Abs(100 - a) == Math.Abs(100 - b))
            {
                Console.WriteLine($"{a} and {b}");
            }
        }
    }
}
