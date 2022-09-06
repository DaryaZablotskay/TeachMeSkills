using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = DialogWithUser();

            do
            {
                string nameOperation = NameOfOperation();
                if (nameOperation=="8")
                {
                    EnterExpression();
                }
                else
                {
                    try
                    {
                        int a = Param();
                        int b = Param();
                        FinalRezult(nameOperation, a, b);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("oops");
                    }
                }
                
                
                Console.WriteLine("Do you want to continue?");
                answer = Console.ReadLine();
            } while (answer == "yes");
        }

        static string DialogWithUser()
        {
            Console.WriteLine("Do you want to continue?");
            string answer = Console.ReadLine();
            return answer;
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
        static void EnterExpression()
        {
            string[] oper = { "+", "-", "/", "*", "%", "^", "sqrt" };
            string a = Expression();
            

            for(int i=0; i<oper.Length; i++)
            {
               bool c = a.Contains(oper[i]);
                if (c)
                {
                    string[] b = a.Split(oper[i]);
                    try
                    {
                        int b1 = Convert.ToInt32(b[0]);
                        int b2 = Convert.ToInt32(b[1]);
                        string nameOperation = oper[i];
                        FinalRezult(nameOperation, b1, b2);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("oops!");
                    }
                    
                }

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
        static string Expression()
        {
            Console.WriteLine("Enter expression");
            string expres = Console.ReadLine();
            return expres;
        }
        static string NameOfOperation()
        {
            Console.WriteLine("1.+");
            Console.WriteLine("2.-");
            Console.WriteLine("3./");
            Console.WriteLine("4.*");
            Console.WriteLine("5.%");
            Console.WriteLine("6.^");
            Console.WriteLine("7.sqrt");
            Console.WriteLine("8.Enter expression");
            Console.WriteLine("Which operation do you want to use?");
            
            string nameOfOperation = Console.ReadLine();
            return nameOfOperation;
           
        }

        
           
        
        static void FinalRezult(string nameOperation, int a, int b)
        {

            

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
                case "^":
                        Power(a, b);
                        break;
                case "sqrt":
                        Square(a, b);
                        break;
                case "8":
                    EnterExpression();
                    break;


                default:
                        SpecialForDefault();
                        break;
               
            }
            
        }
    }
}
