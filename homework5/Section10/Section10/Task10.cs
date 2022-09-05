using System;
using System.Collections.Generic;
using System.Text;

namespace Section10
{
    static class Task10
    {
        public static void Solve()
        {
            int a = EnterNumber();
            Reverse(a);
        }
        static int EnterNumber()
        {
            Console.WriteLine("Enter number with two or more digits");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void Reverse(int a)
        {
            int saveA = a;
             int temp = 0;
            if (a > 0)
            {
                while (a > 0)
                {
                    a /= 10;
                    temp++;
                }
            }
            else
            {
                while (a < 0)
                {
                    a /= 10;
                    temp++;
                }
            }
             
            int newA = 0;
            int j = 1;
            for (int i=(int)Math.Pow(10,temp-1);i>=1; i/=10)
            {
                
                int num;
                num = saveA / i;
                saveA -= num * i;
                newA += num * j;

                j*=10;
                
            }
            Console.WriteLine(newA);

        }
    }
}
