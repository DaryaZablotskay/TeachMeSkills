using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithmExercises
{
    static class Task12
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
            if(a[0]=='C' && a[1]=='#')
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
