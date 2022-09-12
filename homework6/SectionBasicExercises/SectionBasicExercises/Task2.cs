using System;
using System.Collections.Generic;
using System.Text;

namespace SectionBasicExercises
{
    static class Task2
    {
        public static void Solve()
        {
            int a = EnterNumber();
            int b = EnterNumber();
            Sum(a, b);
        }
        static int EnterNumber()
        {
            Console.WriteLine("Enter number");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void Sum(int a, int b)
        {
            Console.WriteLine($"{a}+{b}={a + b}");
        }
    }
}
