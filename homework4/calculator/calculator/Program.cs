using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Repeat();
        }

        static string DialogWithUser()
        {
            Console.WriteLine("Do you want to continue?");
            string answer = Console.ReadLine();
            return answer;
        }
        static void Repeat()
        {
            string answer=DialogWithUser();

            while (answer == "yes")
            {
                FinalRezult();
                Console.WriteLine("Do you want to continue?");
                answer = Console.ReadLine();
            }
        }
        static void Plus(int a, int b)
        {
            Console.WriteLine($"c={a}+{b}={a+b}");
        }

        static void Minus(int a, int b)
        {
            Console.WriteLine($"c={a}-{b}={a - b}");
        }
        static void Division(int a, int b)
        {
            Console.WriteLine($"c={a}/{b}={a / b}");
        }

        static void Multiplication (int a, int b)
        {
            Console.WriteLine($"c={a}*{b}={a * b}");
        }

        static void Percent(int a, int b)
        {
            Console.WriteLine($"c={a}%{b}={a % b}");
        }
        static void Power(int a, int b)
        {
            Console.WriteLine("To what degree do you want to raise the numbers?");
            int stepen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose one number: a or b");
            string sravn = Console.ReadLine();
            if (sravn == "a")
            {
                Console.WriteLine($"c={a}^{stepen}={Math.Pow(a, stepen)}");
            }
            else if (sravn == "b")
            {
                Console.WriteLine($"c={b}^{stepen}={Math.Pow(b, stepen)}");
            }
        }
        static void Square(int a, int b)
        {
            Console.WriteLine("Choose one number: a or b");
            string sravne = Console.ReadLine();
            if (sravne == "a")
            {
                Console.WriteLine($"c={Math.Sqrt(a)}");
            }
            else if (sravne == "b")
            {
                Console.WriteLine($"c={Math.Sqrt(b)}");
            }
        }
        static void SpecialForDefault()
        {
            Console.WriteLine("Error! There is no such operation in the calculator!");
        }
       
        static int Param()
        {
            Console.WriteLine("Enter number");
            int peremen = Convert.ToInt32(Console.ReadLine());
            return peremen;

        }
        static string NameOfOperation()
        {
            Console.WriteLine("Which operation do you want to use?");
            string nameOfOperation = Console.ReadLine();
            return nameOfOperation;
        }

        static void FinalRezult()
        {
            string nameOperation = NameOfOperation();

            int a = Param();
            int b = Param();

            switch (nameOperation)
            {
                case "+":
                    Plus(a, b);
                    break;
                case "-":
                    Minus(a, b);
                    break;
                case "/":
                    Division(a, b);
                    break;
                case "*":
                    Multiplication(a, b);
                    break;
                case "%":
                    Percent(a, b);
                    break;
                case "pow":
                    Power(a, b);
                    break;
                case "sqrt":
                    Square(a, b);
                    break;
                default:
                    SpecialForDefault();
                    break;
            }
        }
    }
}
