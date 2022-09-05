using System;
using System.Collections.Generic;
using System.Text;

namespace Section10
{
    static class Task12
    {
        public static void Solve()
        {
            int a = EnterNumber();
            Console.WriteLine("Check the said number is a palindrome number or not:");
            CheckPalindrome(a);
        }
        static int EnterNumber()
        {
            Console.WriteLine("Enter number for check of palindrom");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void CheckPalindrome(int a)
        {
            
            if(a>10)
            {
                int saveA = a;
                int save2A = a;
                int temp = 0;
                while (a > 0)
                {
                    a /= 10;
                    temp++;
                }
                int newA = 0;
                int j = 1;
                for (int i = (int)Math.Pow(10, temp - 1); i >= 1; i /= 10)
                {

                    int num;
                    num = saveA / i;
                    saveA -= num * i;
                    newA += num * j;

                    j *= 10;

                }
                if (newA == save2A)
                {
                    Console.WriteLine("Palindrome");
                }
                else
                {
                    Console.WriteLine("Dont Palindrome");
                }
            }
            else
            {
                Console.WriteLine("Dont Palindrome");
            }
            
           


        }
    }
}
