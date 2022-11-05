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
        public List<Book> GetBooks(string path)
        {
            using (StreamReader streamReader = new StreamReader(path))
            {
                var json = streamReader.ReadToEnd();
                return JsonConvert.DeserializeObject<List<Book>>(json);
            }
        }

        public void SaveBooks(List<Book> books, string path)
        {
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                var json = JsonConvert.SerializeObject(books, Formatting.Indented);
                streamWriter.WriteLine(json);
            }
        }
    }
}
