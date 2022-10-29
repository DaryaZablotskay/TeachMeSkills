using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HW_25._10.Controllers
{
    [ApiController]
    [Route("task")]
    public class NewController : ControllerBase
    {
        private readonly IDecerialize _decerialize;
        private readonly IConfiguration _config;
        public NewController(IDecerialize decerialize, IConfiguration config)
        {
            _decerialize = decerialize;
            _config = config;
        }

        [HttpGet("first")]
        public string GetFirst()
        {
            return _config.GetValue<string>("DataFile");
        }

        [HttpGet("second")]
        public string GetSecond()
        {
            var path = _config.GetValue<string>("DataFile");
           
            using(StreamReader streamReader = new StreamReader(path))
            {
               return streamReader.ReadToEnd();
            }
        }

        [HttpGet("third-fourth")]
        public List<Subject> GetThird()
        {
            var path = _config.GetValue<string>("DataFile");
            return _decerialize.Decerialization(path);
        }
    }
}
