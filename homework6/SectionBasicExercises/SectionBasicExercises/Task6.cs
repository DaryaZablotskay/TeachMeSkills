using System;
using System.Collections.Generic;
using System.Text;

namespace SectionBasicExercises
{
    static class Task6
    {
        public static void Solve()
        {
            int a = EnterNumber();
            int b = EnterNumber();
            int c = EnterNumber();
            Multiplication(a, b, c);
        }
        static int EnterNumber()
        {
            Console.WriteLine("Enter number");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void Multiplication(int a, int b, int c)
        {
            Console.WriteLine($"a*b*c={a}*{b}*{c}={a * b * c}");
        }
    }
}
