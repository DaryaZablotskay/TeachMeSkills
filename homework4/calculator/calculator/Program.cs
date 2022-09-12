using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            do
            {
                string nameOperation = NameOfOperation();
                if (nameOperation=="Full")
                {
                    EnterExpression();
                }
                else
                {
                    try
                    {
                        double a = Param();
                        double b = Param();
                        FinalRezult(nameOperation, a, b);
                     
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Oops! Enter the correct number!");
                        double c = Param();
                        double d = Param();
                        FinalRezult(nameOperation, c, d);
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Oops! Enter the second number not equal to zero!");
                        double c = Param();
                        double d = Param();
                        FinalRezult(nameOperation, c, d);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Oops! Something went wrong!");
                        double c = Param();
                        double d = Param();
                        FinalRezult(nameOperation, c, d);
                    }
                }
            } while (DialogWithUser() == "yes");
        }
        static void FinalRezult(string nameOperation, double a, double b)
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
                    case "Full":
                        EnterExpression();
                        break;
                    default:
                        SpecialForDefault();
                        break;
                
            }

        }
        static string DialogWithUser()
        {
            Console.WriteLine("Do you want to continue?");
            string answer = Console.ReadLine();
            return answer;
        }

        static void Plus(double a, double b)
        {
            
            double c = a + b;
            int count1 = NumberAfterPoint(a);
            int count2 = NumberAfterPoint(b);
            if(count2>count1)
            {
               double rez = Math.Round(c, count2);
                Console.WriteLine($"c={a}+{b}={rez}");
            }
            else
            {
                double rez = Math.Round(c, count1);
                Console.WriteLine($"c={a}+{b}={rez}");
            }

        }
        static void Minus(double a, double b)
        {
            double c = a - b;
            int count1 = NumberAfterPoint(a);
            int count2 = NumberAfterPoint(b);
            if (count2 > count1)
            {
                double rez = Math.Round(c, count2);
                Console.WriteLine($"c={a}-{b}={rez}");
            }
            else
            {
                double rez = Math.Round(c, count1);
                Console.WriteLine($"c={a}-{b}={rez}");
            }
        }
        static void Division(double a, double b)
        {
            double c = a / b;
            int count1 = NumberAfterPoint(a);
            int count2 = NumberAfterPoint(b);
            if (count2 > count1)
            {
                double rez = Math.Round(c, count2);
                Console.WriteLine($"c={a}/{b}={rez}");
            }
            else
            {
                double rez = Math.Round(c, count1);
                Console.WriteLine($"c={a}/{b}={rez}");
            }
        }
        static void Multiplication (double a, double b)
        {
            double c = a * b;
            int count1 = NumberAfterPoint(a);
            int count2 = NumberAfterPoint(b);
            if (count2 > count1)
            {
                double rez = Math.Round(c, count2);
                Console.WriteLine($"c={a}*{b}={rez}");
            }
            else
            {
                double rez = Math.Round(c, count1);
                Console.WriteLine($"c={a}*{b}={rez}");
            }
        }
        static void Percent(double a, double b)
        {
            double c = a % b;
            int count1 = NumberAfterPoint(a);
            int count2 = NumberAfterPoint(b);
            if (count2 > count1)
            {
                double rez = Math.Round(c, count2);
                Console.WriteLine($"c={a}%{b}={rez}");
            }
            else
            {
                double rez = Math.Round(c, count1);
                Console.WriteLine($"c={a}%{b}={rez}");
            }
        }
        static void Power(double a, double b)
        {
            Console.WriteLine("To what degree do you want to raise the numbers?");
            double stepen = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose one number: a or b");
            string sravn = Console.ReadLine();
            
            int count1 = NumberAfterPoint(a);
            int count2 = NumberAfterPoint(b);
            if (count2 > count1)
            {
                if (sravn == "a")
                {
                    double rez = Math.Round(Math.Pow(a,stepen), count2);
                    Console.WriteLine($"c={a}^{stepen}={rez}");
                }
                else if (sravn == "b")
                {
                    double rez = Math.Round(Math.Pow(b, stepen), count2);
                    Console.WriteLine($"c={b}^{stepen}={rez}");
                }
            }
            else
            {
                if (sravn == "a")
                {
                    double rez = Math.Round(Math.Pow(a, stepen), count1);
                    Console.WriteLine($"c={a}^{stepen}={rez}");
                }
                else if (sravn == "b")
                {
                    double rez = Math.Round(Math.Pow(b, stepen), count1);
                    Console.WriteLine($"c={b}^{stepen}={rez}");
                }
            } 
        }
        static void Square(double a, double b)
        {
            Console.WriteLine("Choose one number: a or b");
            string sravne = Console.ReadLine();
            int count1 = NumberAfterPoint(a);
            int count2 = NumberAfterPoint(b);
            if (count2 > count1)
            {
                if (sravne == "a")
                {
                    double rez = Math.Round(Math.Sqrt(a), count2);
                    Console.WriteLine($"c={rez}");
                }
                else if (sravne == "b")
                {
                    double rez = Math.Round(Math.Sqrt(b), count2);
                    Console.WriteLine($"c={rez}");
                }
            }
            else
            {
                if (sravne == "a")
                {
                    double rez = Math.Round(Math.Sqrt(a), count1);
                    Console.WriteLine($"c={rez}");
                }
                else if (sravne == "b")
                {
                    double rez = Math.Round(Math.Sqrt(b), count1);
                    Console.WriteLine($"c={rez}");
                }
            }   
        }
        static void EnterExpression()
        {
            string[] oper = { "+", "-", "/", "*", "%", "^", "sqrt" };
            string a = Expression();
            //string[] b = a.Split('+', '-', '/', '*', '%', '^') ;
            for (int i = 0; i < oper.Length; i++)
            {
                bool c = a.Contains(oper[i]);
                if (c)
                {
                    string[] b = a.Split(oper[i]);
                    try
                    {
                        double b1 = Convert.ToDouble(b[0]);
                        double b2 = Convert.ToDouble(b[1]);
                        string nameOperation = oper[i];
                        FinalRezult(nameOperation, b1, b2);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Oops! Something went wrong!");
                        EnterExpression();
                    }
                }
            }
        }
        static void SpecialForDefault()
        {
            Console.WriteLine("Error! There is no such operation in the calculator!");
        }
       
        static string NameOfOperation()
        {
            Console.WriteLine("List of operations:");
            Console.WriteLine($"+ {"\n"}- {"\n"}/ {"\n"}* {"\n"}% {"\n"}^ {"\n"}sqrt {"\n"}Full {"\n"}");
            Console.WriteLine("Which operation do you want to use?");
            string nameOfOperation = Console.ReadLine();
            return nameOfOperation;
        }
        static double Param()
        {
             Console.WriteLine("Enter number");
             double peremen = Convert.ToDouble(Console.ReadLine());
             return peremen;
        }
        static string Expression()
        {
            Console.WriteLine("Enter expression");
            string expres = Console.ReadLine();
            return expres;
        }
        static int NumberAfterPoint(double a)
        {
            int i = 1,
                count = 0;
            while((a*Math.Pow(10,i))%10 != 0)
            {
                count++;
                i++;
            }
            return count;
        }

    }
}
