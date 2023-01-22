using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw_09_12.Models
{
    public class UserBook
    {
        public Guid UserBookId { get; set; }
        public Guid? UserId { get; set; }
        public Guid? BookId { get; set; }
        public Book Book { get; set; }
        public User User { get; set; }
    }
}
