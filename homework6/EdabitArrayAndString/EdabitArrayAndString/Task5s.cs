using System;
using System.Collections.Generic;
using System.Text;

namespace EdabitArrayAndString
{
    static class Task5s
    {
        public static void Solve()
        {
            string a = EnterString();
            Console.WriteLine("Is string empty?");
            IsEmpty(a);
        }
        static string EnterString()
        {
            Console.WriteLine("Input your string");
            string a = Console.ReadLine();
            return a;
        }
        static void IsEmpty(string a)
        {
            Console.WriteLine(string.IsNullOrEmpty(a));
        }
    }
}
