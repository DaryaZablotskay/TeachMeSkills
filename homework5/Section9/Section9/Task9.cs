using System;
using System.Collections.Generic;
using System.Text;

namespace Section9
{
    static class Task9
    {
        public static void Solve()
        {
            int a = EnterNumber();
            PrimeNumber(a);
        }
        static int EnterNumber()
        {
            Console.WriteLine("Enter a number for check prime");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void PrimeNumber(int a)
        {
            int temp = 0;
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    temp++;
                }

            }
            if (temp == 0)
            {
                Console.WriteLine($"{a} is a prime number");
            }
            else
            {
                Console.WriteLine($"{a} isn't a prime number");
            }

        }
    }
}
