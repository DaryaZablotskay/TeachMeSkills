using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw_09_12
{
    public class TakeBooksDto
    {
        public string UserFullName { get; set; }
        public DateTime UserBirthDate { get; set; }
        public string BookName { get; set; }
        public int BookYear { get; set; }
        public string AuthorFullName { get; set; }
    }
}
