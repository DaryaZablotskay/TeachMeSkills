using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithmExercises
{
    static class Task9
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
            
          Console.WriteLine(a[a.Length-1] + a + a[a.Length-1]);

        }
    }
}
