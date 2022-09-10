using System;
using System.Collections.Generic;
using System.Text;

namespace SectionString
{
    static class Task4
    {
        public static void Solve()
        {
           string a = EnterString();
            ReverseSeparate(a);
        }
        static string EnterString()
        {
            Console.WriteLine("Input the string");
            string a = Console.ReadLine();
            return a;
        }
        static void ReverseSeparate(string a)
        {
            for(int i=a.Length-1; i>=0; i--)
            {
                Console.Write($"{a[i]}");
            }
        }
    }
}
