using System;
using System.Collections.Generic;
using System.Text;

namespace Section2
{
    static class Task16
    {
        public static void Solve()
        {
            Console.WriteLine("check diapazon 20...50");
            int a = EnterNumber();
            int b = EnterNumber();
            CheckDiapozon(a, b);
        }
        static int EnterNumber()
        {
            Console.WriteLine("Enter number");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void CheckDiapozon(int a, int b)
        {
            bool check;
            check = (((a>=20 && a<=50)&&(b<= 20 || b >= 50)) ||
                ((a <= 20 || a >= 50) && (b >= 20 && b <= 50)));
            Console.WriteLine(check);
        }
    }
    
}
