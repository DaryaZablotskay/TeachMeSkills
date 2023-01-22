using hw_09_12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw_09_12
{
    public class LibraryService : ILibraryService
    {
        private readonly LibraryContext _context;
        public LibraryService(LibraryContext context)
        {
            _context = context;
        }

        public async Task FillUser(UserBook user)
        {
            await _context.UserBooks.AddAsync(user);
            await _context.SaveChangesAsync();
        }
    }
}
