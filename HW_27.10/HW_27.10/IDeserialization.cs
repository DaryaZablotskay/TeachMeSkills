using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW_27._10
{
    public interface IDeserialization
    {
        public List<Book> Deserialize(string path);
    }
}
