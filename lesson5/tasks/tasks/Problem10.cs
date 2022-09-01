using System;
using System.Collections.Generic;
using System.Text;

namespace tasks
{
    static class Problem10
    {
        public static void Solve()
        {
            int a = Number();
            CheckMultiple(a);
        }
        static int Number()
        {
            Console.WriteLine("Enter number");
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        static void CheckMultiple(int a)
        {
            bool check = ((a % 3 == 0) || (a % 7 == 0));
            Console.WriteLine(check);
        }
    }
}
