using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Operation();

            Console.WriteLine("Do you want to continue?");
            string answer = Console.ReadLine();

           while (answer=="yes")
            {
                Operation();
                Console.WriteLine("Do you want to continue?");
                answer = Console.ReadLine();
            }

        }
        static void Operation()
        {
            Console.WriteLine("Which operation do you want to use?");
            string nameOperation = Console.ReadLine();
            Console.WriteLine("Enter two numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
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

                    // % - остаток от деления
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
