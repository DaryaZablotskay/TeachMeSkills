using System;
using System.Collections.Generic;
using System.Text;

namespace SectionString
{
    static class Task2
    {
        public static void Solve()
        {
            string a = EnterString();
            CountChar(a);
        }
        static string EnterString()
        {
            Console.WriteLine("Input the string");
            string a = Console.ReadLine();
            return a;
        }
        static void CountChar(string a)
        {
            int count = 0;
            foreach(char c in a)
            {
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
