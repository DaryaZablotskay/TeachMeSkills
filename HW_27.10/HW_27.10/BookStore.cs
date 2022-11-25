using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HW_27._10
{
    public class BookStore : IBookStore
    {
        public async Task<List<Book>> GetBooksAsync(string path)
        {
            using (StreamReader streamReader = new StreamReader(path))
            {
                var json = await streamReader.ReadToEndAsync();
                return await JsonConvert.DeserializeObjectAsync<List<Book>>(json);
            }
        }

        public async Task SaveBooksAsync(List<Book> books, string path)
        {
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                var json = await JsonConvert.SerializeObjectAsync(books, Formatting.Indented);
                await streamWriter.WriteLineAsync(json);
            }
        }
    }
}
