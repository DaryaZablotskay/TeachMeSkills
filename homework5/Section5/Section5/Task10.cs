using System;
using System.Collections.Generic;
using System.Text;

namespace Section5
{
    static class Task10
    {
        public static void Solve()
        {
            int row = EnterNumber();
            TriangleNumber(row);
        }
        static int EnterNumber()
        {
            Console.WriteLine("Enter number");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void TriangleNumber(int row)
        {
            for(int i=1; i<=row; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
