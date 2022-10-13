using System;
using System.Collections.Generic;
using System.Text;

namespace password
{
    public class OneLowwerException : Exception
    {
        public OneLowwerException(string message) : base(message)
        {
        }
    }
}
