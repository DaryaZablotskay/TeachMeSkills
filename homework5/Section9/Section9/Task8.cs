using System;
using System.Collections.Generic;
using System.Text;

namespace Section9
{
    static class Task8
    {
        public static void Solve()
        {
            int a = EnterNumber();
            Fibonacci(a);
        }
        static int EnterNumber()
        {
            Console.WriteLine("Input number of Fibonacci Series");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void Fibonacci(int a)
        {
            int x1 = 0,
                x2 = 1,
                x3;
            Console.Write($"{x1} {x2} ");
            for(int i=2; i<a; i++)
            {
                x3 = x1 + x2;
                x1 = x2;
                x2 = x3;
                Console.Write($"{x3} ");
            }
            Console.WriteLine();
            
        }
    }
}
