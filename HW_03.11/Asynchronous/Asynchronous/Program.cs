using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Asynchronous
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ComeBackHome();
            var preparingSauce = PrepareSauce();
            Sauce sauce = await preparingSauce;
            var cookingPastaTask = CookPasta(sauce);
            var warmingCutletTask = WarmCutlet();

            Pasta pasta = await cookingPastaTask;
            WarmedCutlet cutlet = await warmingCutletTask;

            Eat(cutlet,pasta);

            var makingTeaTask = MakeTea();
            var washingUpTask = WashUp();

            await Task.WhenAll(makingTeaTask, washingUpTask);

            Console.WriteLine("We have finished everything and are ready for bed!");
            WatchTikTok();
            Sleep();
        }

        public static void ComeBackHome()
        {
            Console.WriteLine("Come home after the course");
        }

        public static async Task<Sauce> PrepareSauce()
        {
            Console.WriteLine("Chop the ingredients");
            Console.WriteLine("Put ingredients in the mixer");

            await Task.Delay(10000);

            Console.WriteLine("Get sauce");

            return new Sauce("cheese sause");
        }

        public static async Task<Pasta> CookPasta(Sauce sause)
        {
            Console.WriteLine("Paur water in pan");
            Console.WriteLine("Put the pan with water on the stove");

            await Task.Delay(10000);

            Console.WriteLine("Add pasta to the water");

            await Task.Delay(10000);

            Console.WriteLine("Put pasta on a plate");
            Console.WriteLine($"Add {sause.Name} to pasta");

            return new Pasta();
        }

        public static async Task<WarmedCutlet> WarmCutlet()
        {
            Console.WriteLine("Get the cutlet from the refrigerator");
            Console.WriteLine("Put it in the microwave");

            await Task.Delay(10000);

            Console.WriteLine("Get warm cutlet");

            return new WarmedCutlet();
        }

        public static void Eat(WarmedCutlet cutlet, Pasta pasta)
        {
            Console.WriteLine("Eat pasta and cutlet");
        }

        public static async Task MakeTea()
        {
            Console.WriteLine("Pour water into the kettle");

            await Task.Delay(10000);

            Console.WriteLine("Pour tea into a cup");

            await Task.Delay(5000);

            Console.WriteLine("Drink tea");
        }

        public static async Task WashUp()
        {
            Console.WriteLine("Turn on tap in bath");

            var takingWater = Task.Delay(20000);

            Console.WriteLine("Brush teeth");

            await takingWater;

            Console.WriteLine("Take a bath");
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
