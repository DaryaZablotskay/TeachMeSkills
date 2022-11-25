using System;
using System.Threading;

namespace Synchronous
{
    class Program
    {
        static void Main(string[] args)
        {
            PrepareSauce();
            ComeBackHome();
            CookPasta();
            WarmCutlet();
            Eat();
            MakeTea();
            WashUp();
            WatchTikTok();
            Sleep();
        }

        public static void ComeBackHome()
        {
            Console.WriteLine("Come home after the course");
        }

        public static void PrepareSauce()
        {
            Console.WriteLine("Chop the ingredients");
            Console.WriteLine("Put ingredients in the mixer");
            Thread.Sleep(10000);
            Console.WriteLine("Get sauce");
        }

        public static void CookPasta()
        {
            Console.WriteLine("Paur water in pan");
            Console.WriteLine("Put the pan with water on the stove");
            Thread.Sleep(10000);
            Console.WriteLine("Add pasta to the water");
            Thread.Sleep(10000);
            Console.WriteLine("Put pasta on a plate");
        }

        public static void WarmCutlet()
        {
            Console.WriteLine("Get the cutlet from the refrigerator");
            Console.WriteLine("Put it in the microwave");
            Thread.Sleep(10000);
            Console.WriteLine("Get warm cutlet");
        }

        public static void Eat()
        {
            Console.WriteLine("Eat pasta and cutlet");
        }

        public static void WashUp()
        {
            Console.WriteLine("Turn on tap in bath");
            Thread.Sleep(10000);
            Console.WriteLine("Brush teeth");
            Console.WriteLine("Take a bath");
        }

        public static void MakeTea()
        {
            Console.WriteLine("Pour water into the kettle");
            Thread.Sleep(10000);
            Console.WriteLine("Pour tea into a cup");
            Thread.Sleep(10000);
            Console.WriteLine("Drink tea");
        }

        public static void WatchTikTok()
        {
            Console.WriteLine("Watch TikTok");
        }

        public static void Sleep()
        {
            Console.WriteLine("Go to sleep");
        }
    }
}
