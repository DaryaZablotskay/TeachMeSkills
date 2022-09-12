using System;
using System.Collections.Generic;
using System.Text;

namespace SectionBasicExercises
{
    static class Task4
    {
        public static void Solve()
        {
            Operation();
        }
        static void Operation()
        {
            Console.WriteLine($"-1+4*6 = {-1 + 4 * 6}");
            Console.WriteLine($"(35+5)%7 = {(35 + 5) % 7}");
            Console.WriteLine($"14+-4*6/11 = {14 + -4 * 6 / 11 }");
            Console.WriteLine($"2+15/6*1-7%2 = {2 + 15 / 6 * 1 - 7 % 2}");
        }
    }
}
