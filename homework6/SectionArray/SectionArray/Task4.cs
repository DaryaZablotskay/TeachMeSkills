using System;
using System.Collections.Generic;
using System.Text;

namespace SectionArray
{
    static class Task4
    {
        public static void Solve()
        {
            int n = EnterNumber();
            ArrayCopy(n);
        }
        static int EnterNumber()
        {
            Console.WriteLine("enter size of array");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void ArrayCopy(int n)
        {
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"element - {i} = {a[i]}");
            }

            int[] b = new int[a.Length];
            for (int i = 0, j = 0 ; i < n; i++, j++)
            {
                b[j] = a[i];
            }
            Console.WriteLine("The elements stored in the first array are :");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine($"{"\n"}The elements copied into the second array are :");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{b[i]} ");
            }


        }
    }
}
