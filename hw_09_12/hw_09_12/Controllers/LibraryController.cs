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


        [HttpPost]
        public async Task FillModels()
        {
            var userBook = new UserBook
            {
                UserBookId = Guid.NewGuid(),
                User = new User
                {
                    UserId = Guid.NewGuid(),
                    FirstName = "Dima",
                    LastName = "Takarevskiy",
                    Email = "DiTak@gmail.com",
                    BirthDate = new DateTime(2003,6,6)
                }
            };
            await _library.FillUser(userBook);
        }

        [HttpGet]
        public IEnumerable<TakeBooksDto> GetBooks()
        {
            var books = _library.TakeBooks();
            return books;
        }

        [HttpDelete]
        public async Task<IEnumerable<string>> DeleteUsers()
        {
            var names = await _library.Delete();
            return names;
        }
    }
}
