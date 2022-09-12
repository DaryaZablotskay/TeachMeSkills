using System;
using System.Collections.Generic;
using System.Text;

namespace EdabitArrayAndString
{
    static class Task4s
    {
        public static void Solve()
        {
            string a = EnterString();
            Console.WriteLine("Is string even?");
            OddOrEven(a);
        }
        static string EnterString()
        {
            Console.WriteLine("Input string");
            string a = Console.ReadLine();
            return a;
        }
        static void OddOrEven(string a)
        {
            if (a.Length%2==0)
            {
                Console.WriteLine("true");

            }
            else
            {
                Console.WriteLine("false");
            }

        }
    }
}
