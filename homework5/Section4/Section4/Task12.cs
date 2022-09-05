using System;
using System.Collections.Generic;
using System.Text;

namespace Section4
{
    static class Task12
    {
        public static void Solve()
        {
            Console.WriteLine("Input the Roll Number of the student:");
            int number = EnterNumber();
            Console.WriteLine("Input the Name of the Student:");
            string name = Console.ReadLine();
            Console.WriteLine("Input the marks of Physics, Chemistry and Computer Application:");
            int ph = EnterNumber();
            int ch = EnterNumber();
            int ca = EnterNumber();

            Output(number, name, ph, ch, ca);
        }
       
        static void Output(int number, string name, int ph, int ch, int ca)
        {
            Console.WriteLine("");
            Console.WriteLine($"Roll No : {number}");
            Console.WriteLine($"Name of Student : {name}");
            Console.WriteLine($"Marks in Physics : {ph}");
            Console.WriteLine($"Marks in Chemistry: {ch}");
            Console.WriteLine($"Marks in Computer Application : {ca}");
            int total = TotalMarks(ph, ch, ca);
            Console.WriteLine($"Total Marks = {total}");
            double per = Percentage(total);
            Console.WriteLine($"Percentage = {per}");
            CheckDivision(per);

        }
        static int EnterNumber()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        static int TotalMarks(int ph, int ch, int ca)
        {
            return ph + ch + ca;
        }
        static double Percentage(int total)
        {
            return total / 3;
        }
        static void CheckDivision(double per)
        {
            if(per>=80)
            {
                Console.WriteLine("Division = First");
            }
            else if(per>=60 && per<80)
            {
                Console.WriteLine("Division = Second");
            }
            else if (per>=40 && per<60)
            {
                Console.WriteLine("Division = Third");
            }
            else if (per>=20 && per<40)
            {
                Console.WriteLine("Division = Fourth");
            }
            else
            {
                Console.WriteLine("Fail!");
            }
        }
    }
}
