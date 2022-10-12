using System;
using System.Collections.Generic;
using System.Text;

namespace password
{
    public class OneSimbolException : Exception
    {
        public OneSimbolException(string message) : base(message)
        {
        }
    }
}
