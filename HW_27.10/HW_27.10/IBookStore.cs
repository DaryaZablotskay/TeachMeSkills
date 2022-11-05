using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW_27._10
{
    public interface IBookStore
    {
        List<Book> GetBooks(string path);
        void SaveBooks(List<Book> books, string path);
    }
}
