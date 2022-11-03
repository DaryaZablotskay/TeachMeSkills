using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW_27._10
{
    public interface ISerialization
    {
        public void Serialize(List<Book> books, string path);
    }
}
