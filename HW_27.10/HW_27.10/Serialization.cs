using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HW_27._10
{
    public class Serialization : ISerialization
    {
        public void Serialize(List<Book> books, string path)
        {
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                var json = JsonConvert.SerializeObject(books, Formatting.Indented);
                streamWriter.WriteLine(json);
            }
        }
    }
}
