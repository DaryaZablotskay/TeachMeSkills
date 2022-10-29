using System;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace HW_25._10
{
    public class Decerialize : IDecerialize
    {
        private readonly IConfiguration _config;
        public List<Subject> Decerialization(string path)
        {
            using (StreamReader streamReader = new StreamReader(path))
            {
                var json = streamReader.ReadToEnd();
                return JsonConvert.DeserializeObject<List<Subject>>(json);
            }
        }
    }
    public interface IDecerialize
    {
        public List<Subject> Decerialization(string path);
    }
}
