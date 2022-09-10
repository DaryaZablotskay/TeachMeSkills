using System;
using System.Collections.Generic;
using System.Text;

namespace SectionString
{
    static class Task9
    {
        public static void Solve()
        {
            string a = EnterString();
            CountVowelConsonant(a);

        }
        static string EnterString()
        {
            Console.WriteLine("Input the string");
            string a = Console.ReadLine();
            return a;
        }
        static void CountVowelConsonant(string a)
        {
            int v = 0;
            int c = 0;
            for(int i=0; i<a.Length; i++)
            {
                if(a[i]== 'a' || a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u' || a[i] == 'y'
                    || a[i] == 'A' || a[i] == 'E' || a[i] == 'I' || a[i] == 'O' || a[i] == 'U' || a[i] == 'Y')
                {
                    v++;
                }
                else if ((a[i] >= 'a' && a[i] <= 'z') || (a[i] >= 'A' && a[i] <= 'Z'))
                {
                    c++;
                }
            }
            Console.WriteLine($"The total number of vowel in the string is : {v}");
            Console.WriteLine($"The total number of consonant in the string is : {c}");
        }
    }
}
