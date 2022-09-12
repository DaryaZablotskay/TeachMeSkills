using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithmExercises
{
    static class Task7
    {
        public static void Solve()
        {
            string a = EnterString();
            Swap(a);
        }
        static string EnterString()
        {
            Console.WriteLine("Enter string");
            return Console.ReadLine();

        }
        static void Swap(string a)
        {
            Console.WriteLine(a[a.Length - 1] +a.Substring(1,a.Length-2)+a[0]);
        }
    }
}
