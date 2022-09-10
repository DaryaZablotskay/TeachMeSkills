using System;
using System.Collections.Generic;
using System.Text;

namespace SectionString
{
    static class Task1
    {
        public static void Solve()
        {
            Console.WriteLine($"The string you entered is : {EnterString()}");

        }
        static string EnterString()
        {
            Console.WriteLine("Input the string");
            string a = Console.ReadLine();
            return a;
        }
    }
}
