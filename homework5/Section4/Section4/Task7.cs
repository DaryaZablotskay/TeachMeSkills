using System;
using System.Collections.Generic;
using System.Text;

namespace Section4
{
    static class Task7
    {
        public static void Solve()
        {
            int a = EnterHeight();
            CheckHeight(a);
        }
        static int EnterHeight()
        {
            Console.WriteLine("Enter height");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void CheckHeight(int a)
        {
            if(a<=150)
            {
                Console.WriteLine("you are low!");
            }
            else if (a>150 && a<=170)
            {
                Console.WriteLine("you are of average height!");
            }
            else
            {
                Console.WriteLine("you are tall!");
            }
        }
    }
}
