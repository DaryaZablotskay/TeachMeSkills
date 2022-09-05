using System;
using System.Collections.Generic;
using System.Text;

namespace Section5
{
    static class Task5
    {
        public static void Solve()
        {
            int n = EnterNumber();
            CubeNumber(n);
        }
        static int EnterNumber()
        {
            Console.WriteLine("Enter number");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void CubeNumber(int n)
        {
            
            for (int i=1; i<=n; i++)
            {
                Console.WriteLine($"{i} : {Math.Pow(i,3)}");

            }
        }
    }
}
