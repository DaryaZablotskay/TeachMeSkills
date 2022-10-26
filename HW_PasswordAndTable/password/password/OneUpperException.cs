using System;
using System.Collections.Generic;
using System.Text;

namespace password
{
    public class OneUpperException:Exception
    {
        public OneUpperException(string message) : base(message)
        {

        }
    }
}
