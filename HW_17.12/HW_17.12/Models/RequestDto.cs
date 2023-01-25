using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW_17._12.Models
{
    public class RequestDto
    {
        public string Topic { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string DepartmentName { get; set; }
        public string SpecialistName { get; set; }
    }
}
