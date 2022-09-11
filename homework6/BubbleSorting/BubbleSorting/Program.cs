using System;

namespace BubbleSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = EnterSize();
            int[] a = FillArray(n);
            BubbleSort(a);
        }
        static int EnterSize()
        {
            Console.WriteLine("Enter size of array");
            return Convert.ToInt32(Console.ReadLine());
        }
        static int [] FillArray(int size)
        {
            int[] a = new int[size];
            for(int i=0; i<size; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            return a;
        }
        static void BubbleSort(int[] a)
        {
            int b=0;
            for(int j=0; j<a.Length; j++)
            {
                for (int i = 0; i < a.Length - 1-j; i++)
                {
                
                        if (a[i] > a[i + 1])
                        {
                            b = a[i];
                            a[i] = a[i + 1];
                            a[i + 1] = b;
                        }

                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]} ");
            }
           
            
        }
           
    }
}
