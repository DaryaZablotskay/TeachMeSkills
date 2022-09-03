using System;
using System.Collections.Generic;
using System.Text;

namespace Section4
{
    static class Task6
    {
        public static void Solve()
        {
            int m = EnterNumber();
            NumberN(m);
        }
        static int EnterNumber()
        {
            Console.WriteLine("Enter number");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void NumberN(int m)
        {
            int n;
            if (m>0)
            {
                n = 1;
                Console.WriteLine($"n={n}");
            }
            else if (m==0)
            {
                n = 0;
                Console.WriteLine($"n={n}");
            }
            else if (m<0)
            {
                n = -1;
                Console.WriteLine($"n={n}");
            }

        }
    }
}
