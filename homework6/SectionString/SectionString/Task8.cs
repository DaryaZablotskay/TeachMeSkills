using System;
using System.Collections.Generic;
using System.Text;

namespace SectionString
{
    static class Task8
    {
        public static void Solve()
        {
            string a = EnterString();
            char []b =new char [a.Length] ;
            Copy(a, b);
        }
        static string EnterString()
        {
            Console.WriteLine("Input the string");
            string a = Console.ReadLine();
            return a;
        }
        static void Copy(string a, char []b)
        {
            int count = 0;
            for(int i=0, j=0; i<a.Length && j<b.Length; i++, j++)
            {
                b[j] = a[i];
                count ++;
            }
            Console.WriteLine($"Number of characters copied : {count}");
        }
    }
}
