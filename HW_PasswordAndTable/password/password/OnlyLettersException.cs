using System;
using System.Collections.Generic;
using System.Text;

namespace password
{
    public class OnlyLettersException : Exception
    {
        public OnlyLettersException(string message) : base(message)
        {
        }
    }
}
