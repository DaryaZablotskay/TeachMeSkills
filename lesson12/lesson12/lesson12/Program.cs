using System;
using System.Collections.Generic;

namespace lesson12
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputRoutin();
            }
            catch(MyException e) when (string.IsNullOrWhiteSpace(e.Message))
            {
                Console.WriteLine("Sorry");
            }
            catch (MyException e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public static void InputRoutin()
        {
            Console.WriteLine("Input number");
            var input = Console.ReadLine();
            
            try
            {
                var i = ProcessInput(input);
            }
            catch (MyException e)
            {
                Console.WriteLine($"Error: {e.Message}");

                //throw;
                //throw e;
            }
            finally
            {

            }
        }
        public static int ProcessInput(string input)
        {
            //var isNumber = int.TryParse(input, out var i);
            var isNumber = int.TryParse(input ?? throw new ArgumentNullException(), out var i);
            return isNumber == true? i: throw new MyException("Input must be number");
        }
    }

    public class SomeClass
    {
        private string _stroka;
        public SomeClass(string stroka)
        {
            _stroka = stroka ?? throw new ArgumentNullException(nameof(stroka));
        }
    }
}
