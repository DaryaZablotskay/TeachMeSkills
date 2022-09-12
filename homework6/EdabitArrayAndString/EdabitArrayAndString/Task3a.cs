using System;
using System.Collections.Generic;
using System.Text;

namespace EdabitArrayAndString
{
    static class Task3a
    {
        public static void Solve()
        {
            int n = EnterNumber();
            int[] a = Array(n);
            Last(a);
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
        static void Last(int[] a)
        {
            Console.WriteLine(a[a.Length-1]);
        }

    }
}
