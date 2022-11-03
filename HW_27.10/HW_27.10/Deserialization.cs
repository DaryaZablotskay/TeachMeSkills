using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HW_27._10
{
    public class Deserialization : IDeserialization
    {
        public List<Book> Deserialize(string path)
        {
            using (StreamReader streamReader = new StreamReader(path))
            {
                var json = streamReader.ReadToEnd();
                return JsonConvert.DeserializeObject<List<Book>>(json);
            }
        }
    }
}
