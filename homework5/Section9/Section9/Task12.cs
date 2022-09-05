using System;
using System.Collections.Generic;
using System.Text;

namespace Section9
{
    static class Task12
    {
        public static void Solve()
        {
            int n = EnterNumber();
            Console.WriteLine($"The Fibonacci of {n} th term is {Fibonachi(n)}");
            
        }
        static int EnterNumber()
        {
            Console.WriteLine("Enter a number for Fibonachi");
            return Convert.ToInt32(Console.ReadLine());
        }
        static int Fibonachi(int n)
        { 
          if(n==0 || n==1)
            {
                return n;
            }
          else
            {
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
        }
    }
    
}

