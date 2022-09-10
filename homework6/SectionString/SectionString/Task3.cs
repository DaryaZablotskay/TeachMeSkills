using System;
using System.Collections.Generic;
using System.Text;

namespace SectionString
{
    static class Task3
    {
        public static void Solve()
        {
            string a = EnterString();
            Separate(a);
        }
        static string EnterString()
        {
            Console.WriteLine("Input the string");
            string a = Console.ReadLine();
            return a;
        }
        static void Separate(string a)
        {
            for(int i=0; i<a.Length; i++)
            {
                Console.Write($"{a[i]} ");
            }

        }
    }
}
