﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SectionArray
{
    static class Task6
    {
        public static void Solve()
        {
            int n = EnterNumber();
            ArrayUnique(n);
        }
        static int EnterNumber()
        {
            Console.WriteLine("enter size of array");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void ArrayUnique(int n)
        {
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"element - {i} = {a[i]}");
            }
            int[] b = new int[n];
            for (int i = 0; i < n; i++)
            {
                b[i] = a[i];
            }
            int count = 0,
                k = 0;
            Console.WriteLine("The unique elements found in the array are :");
            for (int i = 0; i < n; i+=count)
            {
                count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (a[i] == b[j])
                    {
                        count++;
                    }
                    else
                    {
                        count += 0;
                    }
                }
                if (count > 1)
                {
                    k++;
                }
                else if(count==1)
                {
                    Console.Write($"{a[i]} ");
                }
            }
        }
    }
}
