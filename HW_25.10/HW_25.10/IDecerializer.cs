using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW_25._10
{
    public interface IDecerializer
    {
        public List<Subject> Decerialize(string path);
    }
}
