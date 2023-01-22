using hw_09_12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw_09_12.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LibraryController : ControllerBase
    {
        private readonly ILibraryService _library;
        public LibraryController(ILibraryService library)
        {
            _library = library;
        }


        [HttpPost("user")]
        public async Task FillUser()
        {
            var userBook = new UserBook
            {
                UserBookId = Guid.NewGuid(),
                Book = new Book
                {
                    Name = "Harry Potter and the Sorcerer's Stone",
                    Year = 1997,
                    BookId = Guid.NewGuid(),
                    Author = new Author
                    {
                        AuthorId = Guid.NewGuid(),
                        BirthDate = new DateTime(1965, 7, 31),
                        Country = "Great Britain",
                        FirstName = "Joanne",
                        LastName = "Rowling"
                    }
                },
                User = new User
                {
                    UserId = Guid.NewGuid(),
                    FirstName = "Ilya",
                    LastName = "Dobrinskiy",
                    Email = "IlDob@gmail.com",
                    BirthDate = new DateTime(2002, 5, 18)
                }
            };
            await _library.FillUser(userBook);
        }
    }
}
