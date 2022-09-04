using System;
using System.Collections.Generic;
using System.Text;

namespace Section10
{
    static class Task1
    {
        public static void Solve()
        {
            Console.WriteLine("Absolute value of a number of Decimal values:");
            AbsDecimal();
            Console.WriteLine("Absolute value of a number of Double values:");
            AbsDouble();
            Console.WriteLine("Absolute value of a number of Int16 values:");
            AbsInt16();
            Console.WriteLine("Absolute value of a number of Int32 values:");
            AbsInt32();
            Console.WriteLine("Absolute value of a number of Int64 values:");
            AbsInt64();
        }
        static void AbsDecimal()
        {
            decimal de1 = Decimal.MaxValue,
                de2 = 15.55m, de3 = 0m, de4 = -17.23m,
                de5 = Decimal.MinValue;
            Console.WriteLine($"Abs({de1})={Math.Abs(de1)}");
            Console.WriteLine($"Abs({de2})={Math.Abs(de2)}");
            Console.WriteLine($"Abs({de3})={Math.Abs(de3)}");
            Console.WriteLine($"Abs({de4})={Math.Abs(de4)}");
            Console.WriteLine($"Abs({de5})={Math.Abs(de5)}");
        }
        static void AbsDouble()
        {
            double do1 = Double.MaxValue,
                do2 = 1.5354e-16d, do3 = 14.098123d, do4 = 0d,
                do5 = -17.0691730, do6 = -1.4058e+19,
                do7 = Double.MinValue;
            Console.WriteLine($"Abs({do1})={Math.Abs(do1)}");
            Console.WriteLine($"Abs({do2})={Math.Abs(do2)}");
            Console.WriteLine($"Abs({do3})={Math.Abs(do3)}");
            Console.WriteLine($"Abs({do4})={Math.Abs(do4)}");
            Console.WriteLine($"Abs({do5})={Math.Abs(do5)}");
            Console.WriteLine($"Abs({do6})={Math.Abs(do6)}");
            Console.WriteLine($"Abs({do7})={Math.Abs(do7)}");
        }
        static void AbsInt16()
        {
            short s1 = Int16.MaxValue,
                s2 = 10328, s3 = 0, s4 = -1476,
                s5 = Int16.MinValue;

            Console.WriteLine($"Abs({s1})={Math.Abs(s1)}");
            Console.WriteLine($"Abs({s2})={Math.Abs(s2)}");
            Console.WriteLine($"Abs({s3})={Math.Abs(s3)}");
            Console.WriteLine($"Abs({s4})={Math.Abs(s4)}");

            if (s5 == Int16.MinValue)
            {
                Console.WriteLine($"Unable to calculate the absolute value of {s5}");
            }
        }
        static void AbsInt32()
        {
            int i1 = Int32.MaxValue,
                i2 = 16921, i3 = 0, i4 = -804128,
                i5 = Int32.MinValue;

            Console.WriteLine($"Abs({i1})={Math.Abs(i1)}");
            Console.WriteLine($"Abs({i2})={Math.Abs(i2)}");
            Console.WriteLine($"Abs({i3})={Math.Abs(i3)}");
            Console.WriteLine($"Abs({i4})={Math.Abs(i4)}");

            if (i5 == Int32.MinValue)
            {
                Console.WriteLine($"Unable to calculate the absolute value of {i5}");
            }

        }
        static void AbsInt64()
        {
            long l1 = Int64.MaxValue,
                l2 = 0, l3 = -6871982, 
                l4 = Int64.MinValue;

            Console.WriteLine($"Abs({l1})={Math.Abs(l1)}");
            Console.WriteLine($"Abs({l2})={Math.Abs(l2)}");
            Console.WriteLine($"Abs({l3})={Math.Abs(l3)}");

            if (l4 == Int64.MinValue)
            {
                Console.WriteLine($"Unable to calculate the absolute value of {l4}");
            }

        }
    }
}
