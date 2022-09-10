using System;
using System.Collections.Generic;
using System.Text;

namespace SectionBasicExercises
{
    static class Task3
    {
        public static void Solve()
        {
            double a = EnterNumber();
            double b = EnterNumber();
            Dividing(a, b);
        }
        static double EnterNumber()
        {
            Console.WriteLine("Enter number");
            return Convert.ToDouble(Console.ReadLine());
        }
        static void Dividing(double a, double b)
        {
            Console.WriteLine($"{a}/{b}={a / b}");
        }
    }
}
