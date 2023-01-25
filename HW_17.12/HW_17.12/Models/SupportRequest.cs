using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW_17._12.Models
{
    public class SupportRequest
    {
        public Guid SupportRequestId { get; set; }
        public string Topic { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public Guid SupportSpecialistId { get; set; }
        public SupportSpecialist SupportSpecialist { get; set; }
    }
}
