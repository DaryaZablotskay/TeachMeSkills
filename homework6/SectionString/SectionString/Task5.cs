using System;
using System.Collections.Generic;
using System.Text;

namespace SectionString
{
    static class Task5
    {
        public static void Solve()
        {
            string a = EnterString();
            CountWords(a);
        }
        static string EnterString()
        {
            Console.WriteLine("Input the string");
            string a = Console.ReadLine();
            return a;
        }
        static void CountWords(string a)
        {
            int count = 0;
            string[] b = a.Split(' ', '.', ',', '!', '?', '/', '(', ')');
            foreach(string word in b)
            {
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
