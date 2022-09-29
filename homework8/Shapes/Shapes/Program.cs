using System;
using System.Reflection;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a shape: \n" + "Square \n" + "Circle \n" + "Triangle \n" + "Text");
            Console.WriteLine();
            var shape = Console.ReadLine();
            Console.WriteLine();
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
                        var obj = Activator.CreateInstance(item, param);
                        metod?.Invoke(obj, parameters: null);
                    }
                }
            }
        }
    }
}
