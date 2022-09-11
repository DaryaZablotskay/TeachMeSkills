using System;
using System.Collections.Generic;
using System.Text;

namespace EdabitArrayAndString
{
    static class Task3s
    {
        public static void Solve()
        {
            string a = EnterString();
            string b = "Hello, ";
            Console.WriteLine(Concatenate(a, b));
        }
        static string EnterString()
        {
            Console.WriteLine("Input your name");
            string a = Console.ReadLine();
            return a;
        }
        static string Concatenate(string a, string b)
        {
            if(a== "Mubashir")
            {
                string result = string.Concat(b, "my Love");
                return result;
            }
            else
            {
                string result = string.Concat(b, a);
                return result;
            }
            
        }
    }
}
