using System;
using System.Collections.Generic;
using System.Text;

namespace SectionString
{
    static class Task7
    {
        public static void Solve()
        {
            string a = EnterString();
            Count(a);
        }
        static string EnterString()
        {
            Console.WriteLine("Input the string");
            string a = Console.ReadLine();
            return a;
        }
        static void Count(string a)
        {
            int al = 0;
            int di = 0;
            int sp = 0;
            for(int i=0; i<a.Length;i++)
            {
                if((a[i]>='a' && a[i]<='z') ||(a[i]>='A' && a[i]<='Z'))
                {
                    al++;
                }
                else if(a[i]>='0' && a[i]<='9')
                {
                    di++;
                }
                else
                {
                    sp++;
                }
            }
            Console.WriteLine($"Number of Alphabets in the string is : {al}");
            Console.WriteLine($"Number of Digits in the string is : {di}");
            Console.WriteLine($"Number of Special characters in the string is : {sp}");
        }
    }
}
