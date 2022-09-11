using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithmExercises
{
    static class Task22
    {
        public static void Solve()
        {
            string a = EnterString();
            Check(a);
        }
        static string EnterString()
        {
            Console.WriteLine("Enter string");
            return Console.ReadLine();
        }
        static void Check(string a)
        {
            int count = 0;
            for(int i=0; i<a.Length; i++)
            {
                if(a[i]=='z')
                {
                    count++;
                }
            }
            if(count>=2 && count<=4)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
