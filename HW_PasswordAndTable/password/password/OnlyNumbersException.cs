using System;
using System.Collections.Generic;
using System.Text;

namespace password
{
    public class OnlyNumbersException : Exception
    {
        public OnlyNumbersException(string message) : base(message)
        {
        }
    }
}
