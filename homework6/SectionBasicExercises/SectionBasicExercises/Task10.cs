using System;
using System.Collections.Generic;
using System.Text;

namespace SectionBasicExercises
{
    static class Task10
    {
        public static void Solve()
        {
            int x = EnterNumber();
            int y = EnterNumber();
            int z = EnterNumber();
            Operation(x, y, z);
        }
        static int EnterNumber()
        {
            Console.WriteLine("Enter number");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void Operation(int x, int y, int z)
        {
            Console.WriteLine($"(x+y)*z = {(x + y) * z}");
            Console.WriteLine($"x*y+y*z = {x * y + y * z}");
        }
    }
}
