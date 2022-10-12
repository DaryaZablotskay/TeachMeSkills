using System;

namespace Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var table = new Table<string, int, char>();
            Type type = table.GetType();
            Console.WriteLine(type);
            Console.WriteLine("Input number of rows");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<num; i++)
            {
                Console.WriteLine("first:");
                var first = Console.ReadLine();
                Console.WriteLine("second:");
                var second = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("third:");
                var third = Convert.ToChar(Console.ReadLine());

                table.AddRow(first, second, third);
            }
            Heading();
            Console.WriteLine();
            table.Print();
        }
        public static void Heading()
        {
            Console.WriteLine("Input heading");
            var first = Console.ReadLine();
            var second = Console.ReadLine();
            var third = Console.ReadLine();
            Console.WriteLine("{0,-20} | \t {1,-8} | \t {2, -8}", first,second,third);
        }
    }
}
