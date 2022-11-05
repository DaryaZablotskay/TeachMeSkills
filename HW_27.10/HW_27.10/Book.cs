using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW_27._10
{
    public class Book
    {
        public string Name { get; set; }
        public int Pages { get; set; }
        public string Author { get; set; }
        public bool Popularity { get; set; }
        public Guid Id { get; set; }
    }
}
