using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithmExercises
{
    static class Task11
    {
        public static void Solve()
        {
            string a = EnterString();
            Copies(a);
        }
        static string EnterString()
        {
            Console.WriteLine("Enter string");
            return Console.ReadLine();

        }
        static void Copies(string a)
        {
            if (a.Length < 3)
            {
                Console.WriteLine(a+a+a);
            }
            else
            {
                Console.WriteLine(a.Substring(0, 3) + a + a.Substring(0, 3));
            }

        }
    }
}
