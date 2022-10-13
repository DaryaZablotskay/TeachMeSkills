using System;
using System.Collections.Generic;
using System.Text;

namespace lesson12
{
    public class MyException : Exception
    {
        public MyException(string message): base(message)
        {
             
        }
    }
}
