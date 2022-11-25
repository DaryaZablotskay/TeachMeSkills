using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW_27._10
{
    public interface IBookStore
    {
        Task<List<Book>> GetBooksAsync(string path);
        Task SaveBooksAsync(List<Book> books, string path);
    }
}
