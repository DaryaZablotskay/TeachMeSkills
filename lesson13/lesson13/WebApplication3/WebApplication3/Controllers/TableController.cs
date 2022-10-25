using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using homework11;
using Newtonsoft.Json;

namespace WebApplication3.Controllers
{
    [Route("controller")]
    public class TableController : ControllerBase
    {
        [HttpGet]
        public List<Caffe> Get()
        {
            List<Caffe> caffes = new List<Caffe>();

            using (StreamReader streamReader = new StreamReader("D:\\TeachMeSkills\\TeachMeSkillls\\TeachMeSkills\\homework11\\homework11\\homework11\\bin\\Debug\\netcoreapp3.1\\caffe.json"))
            {
                var json = streamReader.ReadToEnd();
                caffes = JsonConvert.DeserializeObject<List<Caffe>>(json);
            }
            return caffes;
        }
        [HttpGet("{index}")]
        public Caffe Get(int index)
        {
            List<Caffe> caffes = new List<Caffe>();

            using (StreamReader streamReader = new StreamReader("D:\\TeachMeSkills\\TeachMeSkillls\\TeachMeSkills\\homework11\\homework11\\homework11\\bin\\Debug\\netcoreapp3.1\\caffe.json"))
            {
                var json = streamReader.ReadToEnd();
                caffes = JsonConvert.DeserializeObject<List<Caffe>>(json);
            }
            var caffeIndex = caffes[index];
            return caffeIndex;
        }
    }
}
