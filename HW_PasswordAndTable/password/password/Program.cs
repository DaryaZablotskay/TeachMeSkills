using System;

namespace password
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The password cant't hold: \n" +
                "just the letters \n" +
                "just the digit \n" +
                "The password should hold: \n" +
                "even one symbol \n" +
                "even one upper lette \n" +
                "even one lowwer letter \n" +
                "The length of password should >=14");
            Console.WriteLine();
            try
            {
                Input();
            }
            catch(OnlyLettersException l)
            {
                Console.WriteLine(l.Message);
                Input();
            }
            catch(OnlyNumbersException n)
            {
                Console.WriteLine(n.Message);
                Input();
            }
            catch(OneSimbolException s)
            {
                Console.WriteLine(s.Message);
                Input();
            }
            catch(OneUpperException u)
            {
                Console.WriteLine(u.Message);
                Input();
            }
            catch(OneLowwerException low)
            {
                Console.WriteLine(low.Message);
                Input();
            }
            catch(Lenght14Exception len)
            {
                Console.WriteLine(len.Message);
                Input();
            }
        }
        public static void Input()
        {
            Console.WriteLine("Input password:");
            var pass = Console.ReadLine();
            if (OnlyLetters(pass))
            {
                throw new OnlyLettersException("The password cant't hold just the letters");
            }
            if(OnlyNumbers(pass))
            {
                throw new OnlyNumbersException("The password can't hold just the digit");
            }
            if(OneSimbol(pass))
            {
                throw new OneSimbolException("The password should hold even one symbol");
            }
            if(OneUpper(pass))
            {
                throw new OneUpperException("The password should hold even one upper letter");
            }
            if(OneLowwer(pass))
            {
                throw new OneLowwerException("The password should hold even one lowwer letter");
            }
            if(Lenght14(pass))
            {
                throw new Lenght14Exception("The length of password should >=14");
            }

        }
        public static bool OnlyLetters(string pass)
        {
            bool check = false;
            foreach (var item in pass)
            {
                check = char.IsLetter(item);
                if (check)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            return check;
        }
        public static bool OnlyNumbers(string pass)
        {
            bool check = false;
            foreach (var item in pass)
            {
                check = char.IsDigit(item);
                if (check)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            return check;
        }
        public static bool OneSimbol(string pass)
        {
            foreach (var item in pass)
            {
                if (!char.IsLetterOrDigit(item))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool OneUpper(string pass)
        {
            foreach (var item in pass)
            {
                if (char.IsUpper(item))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool OneLowwer(string pass)
        {
            foreach (var item in pass)
            {
                if (char.IsLower(item))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool Lenght14(string pass)
        {
            if(pass.Length <14)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
