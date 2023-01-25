using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW_17._12.Models
{
    public class Department
    {
        public Guid DepartmentId { get; set; }
        public string Name { get; set; }
        public ICollection<SupportSpecialist> SupportSpecialists { get; set; }
    }
}
