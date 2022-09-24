using System;

namespace lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            var mouse = new ComputerMouse("average")
            {
               Wheel = new MouseWheel()
            };
            mouse.Volume = 5;
            mouse.Color = "black";
            mouse.ManufacturingCompany = "Microsoft";
            mouse.ManufacturingCountry = "Chine";
            mouse.Click();
            mouse.Description();
            mouse.Wheel.MouseLocation();
            mouse.Wheel.Rotate();
            var blu = new BluetoothMouse("mini");
            blu.BluetoothInterfaceConnecting();
        }
    }


}

