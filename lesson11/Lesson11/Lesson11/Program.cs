using System;
using System.Threading;

namespace Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = new Counter();
            counter.TickEvent += ProccesTick;
            counter.TickEvent += LogTick;


            counter.Tick();
        }

        static void ProccesTick(object callar, TickEventArgs args)
        {
            Console.WriteLine($"Tick {args.TickIndex} proccesed");
        }

        static void LogTick(object callar, TickEventArgs args)
        {
            Console.WriteLine($"Tick {args.TickIndex} loged");
        }
    }
    class Counter
    {
        public event EventHandler<TickEventArgs> TickEvent;
        public void Tick(int ticknumbers = 5000)
        {
            for (int i = 0; i < 5000; i++)
            {
                Thread.Sleep(1000);
                OnTickEvent(i);
            }
        }

        protected virtual void OnTickEvent(int i)
        {
            var args = new TickEventArgs()
            {
                TickIndex = i
            };
            TickEvent?.Invoke(this, args);
        }
    }
    class TickEventArgs : EventArgs
    {
        public int TickIndex { get; set; }
    }
}
