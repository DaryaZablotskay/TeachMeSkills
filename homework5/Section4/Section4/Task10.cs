using System;
using System.Collections.Generic;
using System.Text;

namespace Section4
{
    static class Task10
    {
        public static void Solve()
        {
            Console.WriteLine("Marks in Maths");
            int a = EnterMarks();
            Console.WriteLine("Marks in Physics");
            int b = EnterMarks();
            Console.WriteLine("Marks in Chemistry");
            int c = EnterMarks();
            CheckMarks(a, b, c);
        }
        static int EnterMarks()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        static void CheckMarks(int a, int b, int c)
        {
                if ((a>=65 && b>=55 && c>=50 && a+b+c>=180) || a+b+c>=140)
            {
                Console.WriteLine("The candidate is eligible for admission");
            }
                else
            {
                Console.WriteLine("The candidate isn't eligible for admission");
            }
        }
    }
}
