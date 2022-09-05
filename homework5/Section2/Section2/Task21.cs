using System;
using System.Collections.Generic;
using System.Text;

namespace Section2
{
    static class Task21
    {
        public static void Solve()
        {
            Console.WriteLine("check diapazon 20...30");
            int a = EnterNumber();
            int b = EnterNumber();
            MaxDiapozon(a, b);
        }
        static int EnterNumber()
        {
            Console.WriteLine("Enter number");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void MaxDiapozon(int a, int b)
        {
            if ((a>=20 && a<=30)&&(b>=20 && b<=30))
            {
                if (a>=b)
                {
                    Console.WriteLine($"max = {a}");
                }
                else
                {
                    Console.WriteLine($"max = {b}");
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
