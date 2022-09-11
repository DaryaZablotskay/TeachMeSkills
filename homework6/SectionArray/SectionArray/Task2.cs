using System;
using System.Collections.Generic;
using System.Text;

namespace SectionArray
{
    static class Task2
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
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"element - {i} = {a[i]}");

            }
            Console.WriteLine("The values store into the array are:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine($"{"\n"}The values store into the array in reverse are :");
            for (int i = n-1; i >=0; i--)
            {
                Console.Write($"{a[i]} ");
            }

        }
    }
}
