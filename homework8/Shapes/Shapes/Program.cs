using System;
using System.Reflection;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> inputS = (str) => Console.Write(str);
            Action<char> inputC = (ch) => Console.Write(ch);
            object[] paramMet = new object [] { inputS, inputC };

            Console.WriteLine("Choose a shape: \n" + "Square \n" + "Circle \n" + "Triangle \n" + "Text");
            Console.WriteLine();
            var shape = Console.ReadLine();
            Console.WriteLine();
            object[] paramCon = EnterParam(shape);

            Type type = typeof(IPrintable);
            var metods = type?.GetMethods();
            foreach (var item in metods)
            {
                Console.WriteLine($"Metod: {item}");
            }
            Console.WriteLine("What metod do you want?");
            string metodEnter = Console.ReadLine();
            var metod = type?.GetMethod(metodEnter);

            var types = Assembly.GetAssembly(type)?.GetTypes();

            foreach (var item in types)
            {
                if (item.IsClass && type.IsAssignableFrom(item))
                {
                    if (item.Name == shape)
                    {
                        var obj = Activator.CreateInstance(item, paramCon);
                        var attr = obj.GetType().GetCustomAttributes(false);
                        foreach (var it in attr)
                        {
                            if(it is ColorAttribute colorAttribute)
                            {
                                Console.ForegroundColor = colorAttribute.ColorShape;
                                metod?.Invoke(obj, parameters: paramMet);
                                Console.ResetColor();
                            }
                        }
                    }
                }
            }
        }
        public static object[] EnterParam(string shape)
        {
            Console.WriteLine("Enter the origin of the coordinates by X more than 20:");
            var pointX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the origin of the coordinates by Y:");
            var pointY = Convert.ToInt32(Console.ReadLine());
            object[] param;
            if (shape != "Text")
            {
                Console.WriteLine("Enter the symbol that you will use to draw the shape:");
                var symbol = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Enter the length of the side of the shape:");
                var side = Convert.ToInt32(Console.ReadLine());
                param = new object[] { symbol, pointX, pointY, side };
            }
            else
            {
                Console.WriteLine("Enter text");
                var message = Console.ReadLine();
                param = new object[] { message, pointX, pointY };
            }
            return param;
        }
    }
}
