using System;
using System.Collections.Generic;
using System.Text;

namespace SectionArray
{
    static class Task7
    {
        public static void Solve()
        {
            int n1 = EnterNumber();
            int n2 = EnterNumber();
            CopyArray(n1, n2);
        }
        static int EnterNumber()
        {
            Console.WriteLine("enter size of array");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void CopyArray(int n1, int n2)
        {
            int[] a = new int[n1];
            for (int i = 0; i < n1; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"element - {i} = {a[i]}");
            }
            int[] b = new int[n2];
            for (int i = 0; i < n2; i++)
            {
                b[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"element - {i} = {b[i]}");
            }
            int[] c = new int[n1 + n2];
            for(int i=0; i<n1; i++)
            {
                c[i] = a[i];
            }
            for (int i = n1, j=0; i < n1+n2 && j<n2; i++, j++)
            {
                c[i] = b[j];
            }
            Array.Sort(c);
            for (int k = 0; k< c.Length; k++)
            {
                Console.Write($"{c[k]} ");
            }
           
        }

    }
}
