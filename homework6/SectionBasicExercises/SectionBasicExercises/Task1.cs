using System;
using System.Collections.Generic;
using System.Text;

namespace SectionBasicExercises
{
    static class Task1
    {
        public static void Solve()
        {
            Console.WriteLine($"Hello {EnterName()}");
        }
        static string EnterName()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            return name;
        }
    }
}
