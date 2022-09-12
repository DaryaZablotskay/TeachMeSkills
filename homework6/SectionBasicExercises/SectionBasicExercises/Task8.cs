using System;
using System.Collections.Generic;
using System.Text;

namespace SectionBasicExercises
{
    static class Task8
    {
        public static void Solve()
        {
            int n = EnterNumber();
            MultiplicationTable(n);
        }
        static int EnterNumber()
        {
            Console.WriteLine("Enter number");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void MultiplicationTable(int n)
        {
            for(int i=0; i<=10; i++)
            {
                Console.WriteLine($"{n}*{i}={n*i}");
            }
        }
    }
}
