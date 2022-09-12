using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithmExercises
{
    static class Task17
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
            if (a[1] == 'y' && a[2] == 't')
            {
                Console.WriteLine(a.Remove(1, 2));
            }
            else
            {
                Console.WriteLine(a);
            }
        }
    }
}
