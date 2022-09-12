using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithmExercises
{
    static class Task8
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
            if(a.Length<2)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(a.Substring(0, 2) + a.Substring(0, 2) + a.Substring(0, 2) + a.Substring(0, 2));
            }

        }
    }
}
