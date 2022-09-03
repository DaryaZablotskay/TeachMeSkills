using System;
using System.Collections.Generic;
using System.Text;

namespace Section4
{
    static class Task13
    {
        public static void Solve()
        {
            int temp = EnterTemperature();
            CheckTemperature(temp);
        }
        static int EnterTemperature()
        {
            Console.WriteLine("Enter temperature");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void CheckTemperature(int temp)
        {
            if (temp<0)
            {
                Console.WriteLine("Freezing weather");
            }
            else if(temp>=0 && temp<10)
            {
                Console.WriteLine("Very Cold weather");
            }
            else if (temp>=10 && temp<20)
            {
                Console.WriteLine("Cold weather");
            }
            else if (temp>=20 && temp<30)
            {
                Console.WriteLine("Normal in Temp");
            }
            else if (temp>=30 && temp<40)
            {
                Console.WriteLine("Its Hot");
            }
            else if (temp>=40)
            {
                Console.WriteLine("Very Hot");
            }
        }
    }
}
