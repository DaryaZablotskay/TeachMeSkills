using System;
using System.Collections.Generic;
using System.Text;

namespace Section10
{
    static class Task2
    {
        public static void Solve()
        {
            byte b1 = 1, b2 = 51;
            short s1 = -2, s2 = 52;
            int i1 = -3, i2 = 53;
            long l1 = -4, l2 = 54;
            float f1 = 5f, f2 = 55f;
            double do1 = 6d, do2 = 56d;
            decimal de1 = 7m, de2 = 57m;
            Console.WriteLine("Display the greater of two values");
            Max(b1, b2, s1, s2, i1, i2, l1, l2, f1, f2, do1, do2, de1, de2);
            Console.WriteLine("Display the lesser of two values");
            Min(b1, b2, s1, s2, i1, i2, l1, l2, f1, f2, do1, do2, de1, de2);
        }
        static void Max(byte b1,byte b2,short s1,short s2,int i1 ,int i2, long l1 ,long l2,
        float f1 ,float f2,double do1, double do2,decimal de1,decimal de2)
        {
            
            Console.WriteLine($"Byte : The greater of {b1} and {b2} is {Math.Max(b1,b2)}");
            Console.WriteLine($"Int16 : The greater of {s1} and {s2} is {Math.Max(s1,s2)}");
            Console.WriteLine($"Int32 : The greater of {i1} and {i2} is {Math.Max(i1,i2)}");
            Console.WriteLine($"Int64: The greater of {l1} and {l2} is {Math.Max(l1,l2)}");
            Console.WriteLine($"Single : The greater of {f1} and {f2} is {Math.Max(f1,f2)}");
            Console.WriteLine($"Double: The greater of {do1} and {do2} is {Math.Max(do1,do2)}");
            Console.WriteLine($"Decimal: The greater of {de1} and {de2} is {Math.Max(de1,de2)}");
        }
        static void Min(byte b1, byte b2, short s1, short s2, int i1, int i2, long l1, long l2,
       float f1, float f2, double do1, double do2, decimal de1, decimal de2)
        {
            Console.WriteLine($"Byte : The lesser of {b1} and {b2} is {Math.Min(b1, b2)}");
            Console.WriteLine($"Int16 : The lesser of {s1} and {s2} is {Math.Min(s1, s2)}");
            Console.WriteLine($"Int32 : The lesser of {i1} and {i2} is {Math.Min(i1, i2)}");
            Console.WriteLine($"Int64: The lesser of {l1} and {l2} is {Math.Min(l1, l2)}");
            Console.WriteLine($"Single : The lesser of {f1} and {f2} is {Math.Min(f1, f2)}");
            Console.WriteLine($"Double: The lesser of {do1} and {do2} is {Math.Min(do1, do2)}");
            Console.WriteLine($"Decimal: The lesser of {de1} and {de2} is {Math.Min(de1, de2)}");
        }
    }
}
