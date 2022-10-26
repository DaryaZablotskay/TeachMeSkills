using System;

namespace csharpbasic
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Write your name");
           
           string name= Console.ReadLine();

           Console.WriteLine($"Hello {name}");


        }

        static string Sayhello ()
        {
            return "Hello";
        }
    }
}
