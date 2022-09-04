using System;
using System.Collections.Generic;
using System.Text;

namespace Section5
{
    static class Task7
    {
        public static void Solve()
        {
            int row = 10;
            int col = EnterNumber();
            MultiplicationTable(col, row);
        }
        static int EnterNumber()
        {
            Console.WriteLine("Input upto the table number starting from 1 : 8");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void MultiplicationTable(int col, int row)
        {
            for (int i=1; i<=row; i++)
            {
                for(int j=1; j<= col; j++)
                {
                    Console.Write($"{j}x{i}={j * i}, ");
                }
                Console.WriteLine();
            }
        }

    }
}
