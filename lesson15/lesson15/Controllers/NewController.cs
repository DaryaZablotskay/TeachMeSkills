using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        private readonly ComplexSettings _complexSettings;
        public NewController(IHomeServises homeServises, IConfiguration config, IOptions<ComplexSettings> complexSettings)
        {
            _homeServices = homeServises;
            _config = config;
            _complexSettings = complexSettings.Value;

        }

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

        //public IActionResult GetSetting()
        [HttpGet("setting/{id:int}")]
        public ActionResult<ComplexSettings> GetSetting([FromRoute]int id, [FromQuery]string param)
        {
            //return _config.GetValue<string>("ComplexSettings : InnerSetting");
            // return _config["ComplexSettings : InnerSetting"];
            //return _config.GetSection("ComplexSettings").Get<ComplexSettings>();

            if(id>20)
            {
                return BadRequest();
            }
            return Ok(_complexSettings);
        }

        [HttpPost("post")]
        public void Data([FromBody] BodyData data)
        {
            HttpContext.Response.StatusCode = 400;

        }
       
    }
    public class BodyData
    {
        [Range(0,10)]
        public int Number { get; set; }
    }
}
