using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithmExercises
{
    static class Task6
    {
        public static void Solve()
        {
            string a = EnterString();
            int n = EnterNumber();
            Remove(a, n);
        }
        static string EnterString()
        {
            Console.WriteLine("Enter string");
            return Console.ReadLine();
            
        }
        static int EnterNumber()
        {
            Console.WriteLine("Enter number");
            return Convert.ToInt32(Console.ReadLine());
        }

        static void Remove(string a, int n)
        {
            Console.WriteLine(a.Remove(n, 1));
  
        }
    }
}
