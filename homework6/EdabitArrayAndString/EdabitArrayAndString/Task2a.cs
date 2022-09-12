using System;
using System.Collections.Generic;
using System.Text;

namespace EdabitArrayAndString
{
    static class Task2a
    {
        public static void Solve()
        {
            int n = EnterNumber();
            int[] a = Array(n);
            Difference(a);
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
        static void Difference(int [] a)
        {
            int max = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine($"max = {max}");

            int min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            Console.WriteLine($"min = {min}");

            Console.WriteLine($"max - min = {max}-{min} = {max - min}");
        }
    }
}
