using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw_09_12.Models
{
    public class Book
    {
        public Guid BookId { get; set; }
        public string Name { get; set; }
        public Guid? AuthorId { get; set; }
        public int Year { get; set; }
        public Author Author { get; set; }
        public ICollection<UserBook> UserBooks { get; set; }
    }
}
