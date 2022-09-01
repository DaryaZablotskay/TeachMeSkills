using System;
using System.Collections.Generic;
using System.Text;

namespace tasks
{
    static class Problem3
    {
        public static void Solve()
        {
            int a = Number();
            int b = Number();
            CheckNumbers(a, b);
        }
        static int Number()
        {
            Console.WriteLine("Enter number");
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        static void CheckNumbers(int a, int b)
        {
            bool check=false;
            if (a==30 || b==30 || a+b==30 )
            {
                Console.WriteLine(check = (a == 30 || b == 30 || a + b == 30) );
            }
            else
            {
                Console.WriteLine(check);
            }
        }
    }
}
