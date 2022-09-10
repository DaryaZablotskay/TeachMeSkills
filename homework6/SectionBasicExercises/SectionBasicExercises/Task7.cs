using System;
using System.Collections.Generic;
using System.Text;

namespace SectionBasicExercises
{
    static class Task7
    {
        public static void Solve()
        {
            int a = EnterNumber();
            int b = EnterNumber();
            Sum(a, b);
            Minus(a, b);
            Multiplying(a, b);
            Dividing(a, b);
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
        static void Minus(int a, int b)
        {
            Console.WriteLine($"{a}-{b}={a - b}");
        }
        static void Multiplying(int a, int b)
        {
            Console.WriteLine($"{a}*{b}={a * b}");
        }
        static void Dividing(int a, int b)
        {
            Console.WriteLine($"{a}/{b}={a / b}");
            Console.WriteLine($"{a} mod {b}={a % b}");
        }
    }
}
