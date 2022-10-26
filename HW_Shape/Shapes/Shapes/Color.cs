using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class ColorAttribute : Attribute
    {
        public ConsoleColor ColorShape { get; set; }
        public ColorAttribute(ConsoleColor color)
        {
            ColorShape = color;
        }

    }
}
