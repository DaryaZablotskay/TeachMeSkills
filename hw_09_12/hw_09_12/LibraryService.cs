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

        public IEnumerable<TakeBooksDto> TakeBooks()
        {
            var bookTake = (from userBook in _context.UserBooks
                            join user in _context.Users on userBook.UserId equals user.UserId
                            join book in _context.Books on userBook.BookId equals book.BookId
                            join author in _context.Authors on book.AuthorId equals author.AuthorId
                            select new TakeBooksDto
                            {
                                UserFullName = user.FirstName + " " + user.LastName,
                                UserBirthDate = user.BirthDate,
                                BookName = book.Name,
                                BookYear = book.Year,
                                AuthorFullName = author.FirstName + " " + author.LastName
                            }
                            ).ToList();
            return bookTake;
        }

        public IEnumerable<string> Delete()
        {
            var users = (from userBook in _context.UserBooks
                         join user in _context.Users on userBook.UserId equals user.UserId
                         select new ModelForDeleteDto
                         {
                             BookId = userBook.BookId,
                             UserName = user.FirstName + " " + user.LastName
                         }
                         ).Where(x => x.BookId == null).ToList();

        }
    }
}
