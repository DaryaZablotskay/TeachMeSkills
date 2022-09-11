using System;
using System.Collections.Generic;
using System.Text;

namespace SectionArray
{
    static class Task1
    {
        public static void Solve()
        {
            int n = EnterNumber();
            Array(n);
        }
        static int EnterNumber()
        {
            Console.WriteLine("enter size of array");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void Array(int n)
        {
            int[] a =new int [n];
            for(int i=0; i<n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"element - {i} = {a[i]}");
               
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} ");
            }

        }
    }
}
