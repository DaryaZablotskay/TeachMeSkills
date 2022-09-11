using System;
using System.Collections.Generic;
using System.Text;

namespace EdabitArrayAndString
{
    static class Task2s
    {
        public static void Solve()
        {
            string a = EnterString();
            string b = "Edabit";
            Console.WriteLine(Concatenate(a, b));
        }
        static string EnterString()
        {
            Console.WriteLine("Input the string");
            string a = Console.ReadLine();
            return a;
        }
        static string Concatenate(string a, string b)
        {
            string result = string.Concat(a, b);
            return result;
        }

    }
}
