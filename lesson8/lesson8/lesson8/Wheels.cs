using System;
using System.Collections.Generic;
using System.Text;

namespace lesson8
{
    public class Wheels
    {
        public  string Size { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }
        public string Form { get; set; }

        public Wheels()
        {

        }

        public void Rotate()
        {
            Console.WriteLine("rotate");
        }
    }
}
