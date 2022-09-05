using System;
using System.Collections.Generic;
using System.Text;

namespace Section10
{
    static class Task14
    {
        public static void Solve()
        {
            double a = EnterNumber();
            Console.WriteLine($"Value largest int value smallest int value " +
                $"{"\n"} Value less than or equal greater than or equal");
            Borders(a);
        }
      static double EnterNumber()
        {
            Console.WriteLine("Enter number double");
            return Convert.ToDouble(Console.ReadLine());
        }
        static void Borders(double a)
        {
            Console.WriteLine($"{a}, {Math.Ceiling(a)} {Math.Floor(a)}");
        }
    }
}
