using System;
using System.Collections.Generic;
using System.Text;

namespace SectionArray
{
    static class Task9
    {
        public static void Solve()
        {
            int n = EnterNumber();
            int [] a =Array(n);
            Max(a);
            Min(a);
        }
        static int EnterNumber()
        {
            Console.WriteLine("enter size of array");
            return Convert.ToInt32(Console.ReadLine());
        }
        static int[] Array(int n)
        {
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"element - {i} = {a[i]}");
            }
            return a;
        }
        static void Max(int [] a)
        {
            int max = 0;
            for(int i=0; i<a.Length; i++)
            {
                if(a[i]>max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine($"max = {max}");
        }
        static void Min(int[] a)
        {
            int min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            Console.WriteLine($"min = {min}");
        }
    }
}
