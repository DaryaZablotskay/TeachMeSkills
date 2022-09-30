using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public interface IPrintable
    {
        public void Print(Action <string> inputS, Action<char> inputC);
    }
}
