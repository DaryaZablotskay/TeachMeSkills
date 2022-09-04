using System;
using System.Collections.Generic;
using System.Text;

namespace Section10
{
    static class Task3
    {
        public static void Solve()
        {
            PowThree();
        }
        static void PowThree()
        {
            long result;
            for(int i=0; i<=32; i++)
            {
                result = (long)Math.Pow(3, i);
                Console.WriteLine($"3 ^ {i} = {result}");
            }
        }
    }
}
