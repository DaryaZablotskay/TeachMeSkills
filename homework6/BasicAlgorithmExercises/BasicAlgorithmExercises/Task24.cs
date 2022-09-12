using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithmExercises
{
    static class Task24
    {
        public static void Solve()
        {
            string a = EnterString();
            Upper(a);
        }
        static string EnterString()
        {
            Console.WriteLine("Enter string");
            return Console.ReadLine();
        }
        static void Upper(string a)
        {
            if (a.Length<3)
            {
                Console.WriteLine(a.ToUpper());
            }
            else
            {
                string str1 = a.Remove(a.Length - 3);
                Console.WriteLine(str1);
                string str2 = a.Substring(a.Length - 3).ToUpper();
                Console.WriteLine(str2);
                Console.WriteLine(str1 + str2);
            }
        }
    }
}
