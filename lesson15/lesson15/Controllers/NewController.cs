using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lesson15.Controllers
{
    [ApiController]
    [Route("home")]
    public class NewController :ControllerBase
    {
        private readonly IHomeServises _homeServices;
        private readonly IConfiguration _config;
        public NewController(IHomeServises homeServises, IConfiguration config)
        {
            _homeServices = homeServises;
            _config = config;
        }
        //public NewController(IA a, IB b, IC c)
        //{
            
        //}
        [HttpGet]
        public string Get()
        {
            return _homeServices.Print();
        }
        [HttpGet("key")]
        public string GetKey()
        {
            return _config.GetValue<string>("SecretKey");
        }
    }
}
