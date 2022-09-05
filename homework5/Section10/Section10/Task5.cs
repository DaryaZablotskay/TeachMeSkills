using System;
using System.Collections.Generic;
using System.Text;

namespace Section10
{
    static class Task5
    {
        public static void Solve()
        {
            Console.WriteLine("Test the sign of the following types of values:");
            byte b = 0;
            short s = -2;
            int i = -3;
            long l = -4;
            float f = 2.1f;
            double dob= 6d;
            decimal de = -7m;

            int b1 = Math.Sign(b);
            int s1 = Math.Sign(s);
            int i1 = Math.Sign(i);
            int l1 = Math.Sign(l);
            int f1 = Math.Sign(f);
            int dob1 = Math.Sign(dob);
            int de1 = Math.Sign(de);

            Console.Write($"Byte: {b} "); 
            Sign(b1);
            Console.Write($"{"\n"}Int16: {s} ");
            Sign(s1);
            Console.Write($"{"\n"}Int32: {i} ");
            Sign(i1);
            Console.Write($"{"\n"}Int64: {l} ");
            Sign(l1);
            Console.Write($"{"\n"}Single: {f} ");
            Sign(f1);
            Console.Write($"{"\n"}Double: {dob} ");
            Sign(dob1);
            Console.Write($"{"\n"}Decimal: {de} ");
            Sign(de1);

        }
        static void Sign(int test)
        {
            if(test==-1)
            {
                Console.WriteLine("is less than zero");
            }
            else if (test == 0)
            {
                Console.WriteLine("is equal to zero");
            }
            else if (test == 1)
            {
                Console.WriteLine("is greater than zero");
            }
        }

    }
}
