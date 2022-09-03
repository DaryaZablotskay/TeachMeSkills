using System;
using System.Collections.Generic;
using System.Text;

namespace Section4
{
    static class Task4
    {
        public static void Solve()
        {
            int a = EnterYear();
            CheckLeap(a);
        }
        static int EnterYear()
        {
            Console.WriteLine("Enter year");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void CheckLeap(int a)
        {
            if (a%4==0)
            {
                if (a%100==0)
                {
                    if (a%400==0)
                    {
                        Console.WriteLine("Leap year");
                    }
                    else
                    {
                        Console.WriteLine("dont leap year");
                    }
                }
                else
                {
                    Console.WriteLine("Leap year");
                }

            }
            else
            {
                Console.WriteLine("dont leap year");
            }
        }
    }
}
