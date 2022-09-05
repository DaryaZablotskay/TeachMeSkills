using System;
using System.Collections.Generic;
using System.Text;

namespace Section9
{
    static class Task2
    {
        public static void Solve()
        {
            string name = EnterName();
            Welcome(name);
        }
        static string EnterName()
        {
            Console.WriteLine("Please input a name");
            return Console.ReadLine();
        }
        static void Welcome(string name)
        {
            Console.WriteLine($"Welcome friend {name}! {"\n"}Have a nice day!");
        }
    }
}
