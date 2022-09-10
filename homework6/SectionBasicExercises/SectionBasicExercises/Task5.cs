using System;
using System.Collections.Generic;
using System.Text;

namespace SectionBasicExercises
{
    static class Task5
    {
        public static void Solve()
        {
            int a = EnterNumber();
            int b = EnterNumber();
            Swap(a,b);
        }
        static int EnterNumber()
        {
            Console.WriteLine("Enter number");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void Swap(int a, int b)
        {
            int saveA = a;
            a = b;
            b = saveA;
            Console.WriteLine($"After Swapping : First Number {a} and Second Number {b}");
        }
    }
}
