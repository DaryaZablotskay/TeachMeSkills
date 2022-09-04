using System;
using System.Collections.Generic;
using System.Text;

namespace Section10
{
    static class Task7
    {
        public static void Solve()
        {
            decimal x = 52.7365m;
            decimal y= -52.736m;
            double a = 92.73165;
            double b = -42.7636;

            Console.WriteLine($"Original Decimal Number: {x}" +
                $"{"\n"}The whole number and fractional part of the said positive Decimal number:");
            TruncateDec(x);
            Console.WriteLine($"Original Decimal Number: {y}" +
                $"{"\n"}The whole number and fractional part of the said negative Decimal number:");
            TruncateDec(y);
            Console.WriteLine($"Original Double Number: {a}" +
                 $"{"\n"}The whole number and fractional part of the said positive Float number:");
            TruncateDoub(a);
            Console.WriteLine($"Original Double Number: {b}" +
                 $"{"\n"}The whole number and fractional part of the said negative Float number:");
            TruncateDoub(b);

        }
        static void TruncateDec(decimal test)
        {
            Console.WriteLine(Math.Truncate(test));
            Console.WriteLine(test - Math.Truncate(test));
        }
        static void TruncateDoub(double test)
        {
            Console.WriteLine(Math.Truncate(test));
            Console.WriteLine(test - Math.Truncate(test));
        }
    }
}
