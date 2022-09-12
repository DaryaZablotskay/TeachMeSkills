using System;
using System.Collections.Generic;
using System.Text;

namespace SectionBasicExercises
{
    static class Task9
    {
        public static void Solve()
        {
            int a = EnterNumber();
            int b = EnterNumber();
            int c = EnterNumber();
            int d = EnterNumber();
            Average(a, b, c, d);
        }
        static int EnterNumber()
        {
            Console.WriteLine("Enter number");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void Average(int a, int b, int c, int d)
        {
            double av = (a + b + c + d) / 4;
            Console.WriteLine(av);
        }
    }
}
