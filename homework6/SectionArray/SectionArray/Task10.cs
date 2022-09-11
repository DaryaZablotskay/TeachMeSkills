using System;
using System.Collections.Generic;
using System.Text;

namespace SectionArray
{
    static class Task10
    {
        public static void Solve()
        {
            int n = EnterNumber();
            int[] a = Array(n);
            Separate(a);
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
        static void Separate(int [] a)
        {
            
            int k = 0,
                l = 0,
                countE = 0,
                countO = 0;
            for(int i=0; i<a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    countE++;
                }
                else
                {
                    countO++;
                }
            }
            int[] even = new int[countE];
            int[] odd = new int[countO];
            for (int i=0; i<a.Length; i++)
            {
                if(a[i]%2==0)
                {
                    even[k] = a[i];
                    k++;
                }
                else
                {
                    odd[l] = a[i];
                    l++;
                }
            }
            Console.WriteLine("The Even elements are:");
            for(int j=0; j<even.Length; j++)
            {
                Console.Write($"{even[j]} ");
            }
            Console.WriteLine($"{"\n"}The Odd elements are :");
            for (int j = 0; j < odd.Length; j++)
            {
                Console.Write($"{odd[j]} ");
            }
        }
    }
}
