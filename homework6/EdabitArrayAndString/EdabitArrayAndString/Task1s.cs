using System;
using System.Collections.Generic;
using System.Text;

namespace EdabitArrayAndString
{
    static class Task1s
    {
        public static void Solve()
        {
            string a = EnterString();
            GiveMeSomething(a);
        }
        static string EnterString()
        {
            Console.WriteLine("Input the string");
            string a = Console.ReadLine();
            return a;
        }
        static void GiveMeSomething(string a)
        {
            Console.WriteLine($"something {a}");
        }
    }
}
