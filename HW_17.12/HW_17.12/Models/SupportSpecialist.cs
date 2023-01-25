using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW_17._12.Models
{
    public class SupportSpecialist
    {
        public Guid SupportSpecialistId { get; set; }
        public string Name { get; set; }
        public ICollection<SupportRequest> SupportRequests { get; set; }
        public Guid DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
