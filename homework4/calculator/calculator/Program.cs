using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which operationdo you want to use?");
            string nameOperation = Console.ReadLine();
            Console.WriteLine("Enter two numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Operation(nameOperation, a, b);


           
        }
        static void Operation(string nameOperation, int a, int b)
        {
            switch (nameOperation)
            {
                case "+":
                    Console.WriteLine($"c={a}+{b}={a + b}");
                    break;
                case "-":
                    Console.WriteLine($"c={a}-{b}={a - b}");
                    break;
                case "/":
                    Console.WriteLine($"c={a}/{b}={a / b}");
                    break;
                case "*":
                    Console.WriteLine($"c={a}*{b}={a * b}");
                    break;
                case "%":
                    Console.WriteLine($"c={a}%{b}={a % b}");
                    break;
                case "pow":
                    Console.WriteLine("To what degree do you want to raise the numbers?");
                    int d = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Choose one number: a or b");
                    string h = Console.ReadLine();
                    if (h == "a")
                    {
                        Console.WriteLine($"c={a}^{d}={Math.Pow(a, d)}");
                    }
                    else if (h == "b")
                    {
                        Console.WriteLine($"c={b}^{d}={Math.Pow(b, d)}");
                    }
                    break;
                case "sqrt":
                    Console.WriteLine("Choose one number: a or b");
                    string j = Console.ReadLine();
                    if (j == "a")
                    {
                        Console.WriteLine($"c={Math.Sqrt(a)}");
                    }
                    else if (j == "b")
                    {
                        Console.WriteLine($"c={Math.Sqrt(b)}");
                    }
                    break;
                default:
                    Console.WriteLine("Error! There is no such operation in the calculator!");
                    break;
            }
        }
    }
}
