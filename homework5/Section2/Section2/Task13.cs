using System;
using System.Collections.Generic;
using System.Text;

namespace Section2
{
    static class Task13
    {
        public static void Solve()
        {
            int firstTemperature = EnterNumber();
            int secondTemperarure = EnterNumber();
            Check(firstTemperature, secondTemperarure);
        }
        static int EnterNumber()
        {
            Console.WriteLine("Enter temperature");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void Check(int firstTemperature, int secondTemperarure)
        {
            bool check;
            check = ((firstTemperature > 100 && secondTemperarure < 0)
                || (firstTemperature <0  && secondTemperarure >100));
            Console.WriteLine(check);
        }
    }
}
