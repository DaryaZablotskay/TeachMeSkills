using System;
using System.Collections.Generic;
using System.Text;

namespace Section9
{
    static class Task10
    {
        public static void Solve()
        {
            int a = EnterNumber();
            SumIndividualDigits(a);
        }
        static int EnterNumber()
        {
            Console.WriteLine("Enter a number");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void SumIndividualDigits(int a)
        {
            int sum = 0;
            while (a > 0)
            {
                int i = 10;
                sum += (a % i);
                a /= i;
            }

            Console.WriteLine(sum);
        }
    }
}