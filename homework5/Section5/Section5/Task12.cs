﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Section5
{
    static class Task12
    {
        public static void Solve()
        {
            int row = EnterNumber();
            Triangle(row);
        }
        static int EnterNumber()
        {
            Console.WriteLine("Enter number row");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void Triangle(int row)
        {
            int a = 1;
            for(int i=1; i<=row; i++)
            {
                for(int j=1; j<=i; j++)
                {

                    Console.Write($"{a++} ");
                }
                Console.WriteLine();
            }
        }
    }

}
