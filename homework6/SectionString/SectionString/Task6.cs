using System;
using System.Collections.Generic;
using System.Text;

namespace SectionString
{
    static class Task6
    {
        public static void Solve()
        {
           string a = EnterString();
           string b = EnterString();
            Compare(a, b);
        }
        static string EnterString()
        {
            Console.WriteLine("Input the string");
            string a = Console.ReadLine();
            return a;
        }
        static void Compare(string a, string b)
        {
            int count = 0;
            for (int i = 0, j = 0; i<a.Length && j<b.Length; i++, j++)
            {
                if(a[i]==b[j])
                {
                    count = 1;
                }
                else
                {
                    count = 0;
                }
            }
            if(count==1)
            {
                Console.WriteLine("Both strings are equal.");
            }
            else
            {
                Console.WriteLine("Both strings are not equal.");
            }
        }
        
    }
}
