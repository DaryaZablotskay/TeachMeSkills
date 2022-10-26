using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lesson15
{
    public class HomeServises : IHomeServises
    {
        public string Print()
        {
            return "Hello Dasha";
        }
    }
    public interface IHomeServises
    {
        public string Print();
    }
}
