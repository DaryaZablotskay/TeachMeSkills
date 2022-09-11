using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithmExercises
{
    static class Task25
    {
        public static void Solve()
        {
            string a = EnterString();
            int n = EnterCopies();
            Copies(a,n);
        }
        static string EnterString()
        {
            Console.WriteLine("Enter string");
            return Console.ReadLine();
        }
        static int EnterCopies()
        {
            Console.WriteLine("Enter copies");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void Copies(string a, int n)
        {
            string cop =null;
            for(int i=1; i<=n; i++)
            {
                cop +=a;
            }
            Console.WriteLine(cop);
        }
    }
}
