using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw_09_12
{
    public class ModelForDeleteDto
    {
        public Guid UserId { get; set; }
        public Guid? BookId { get; set; }
        public string UserName { get; set; }
    }
}
