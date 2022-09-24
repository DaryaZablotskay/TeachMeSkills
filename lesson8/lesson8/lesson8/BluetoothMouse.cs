using System;
using System.Collections.Generic;
using System.Text;

namespace lesson8
{
    public class BluetoothMouse : ComputerMouse
    {
        public BluetoothMouse(string size) : base(size)
        {
        }
        public bool Wire { get; set; }

        public void BluetoothInterfaceConnecting()
        {
            Console.WriteLine($"Interface: Bluetooth with {_size}");
        }
    }
}
