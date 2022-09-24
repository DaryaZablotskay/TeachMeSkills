using System;
using System.Collections.Generic;
using System.Text;

namespace lesson8
{
    public class ComputerMouse
    {
        public readonly string _size;
        public string Color { get; set; }
        public string ManufacturingCompany { get; set; }
        public string ManufacturingCountry { get; set; }
        public int Volume { get; set; }

        public MouseWheel Wheel { get; set; }

        public ComputerMouse(string size)
        {
            _size = size;
        }

        public void Click()
        {
            Console.WriteLine($"click-click with volume {Volume}");
        }
        public void Description()
        {
            Console.WriteLine($"{Color}, {_size}, {ManufacturingCompany}, { ManufacturingCountry}");
        }

    }
}
