using System;
using System.Collections.Generic;
using System.Text;

namespace Section10
{
    static class Task8
    {
        public static void Solve()
        {
            int a1 = 2147483647,
                a2 = 23547,
                a3 = 0,
                a4 = -12547,
                a5 = -2147483648,
                b1 = 4000,
                b2 = -4000;

            TruncateInt(a1,b1);
            TruncateInt(a2, b1);
            TruncateInt(a3, b1);
            TruncateInt(a4, b1);
            TruncateInt(a5, b1);
            TruncateInt(a1, b2);
            TruncateInt(a2, b2);
            TruncateInt(a3, b2);
            TruncateInt(a4, b2);
            TruncateInt(a5, b2);
        }
        static void TruncateInt(int a, int b)
        {
            int c;
            int d = Math.DivRem(a,b, out c);
            Console.WriteLine($"{a}/{b}={d}, remainder {c}");
        }
    }
}
