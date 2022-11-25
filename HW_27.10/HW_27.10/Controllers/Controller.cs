using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HW_27._10.Controllers
{
    [ApiController]
    [Route("book")]
    public class Controller : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IBookStore _bookStore;
        public readonly string _path;
        public Controller(IConfiguration config, IBookStore bookStore)
        {
            _bookStore = bookStore;
            _config = config;
            _path = _config.GetValue<string>("dataFilePath");
        }

        [HttpGet("all")]
        public async Task<ActionResult<List<Book>>> GetAll()
        {
            var books = await _bookStore.GetBooksAsync(_path);
            if (books is null)
            {
                return NotFound();
            }
            else
            {
                return books;
            }
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<Book>> GetOne([FromRoute] Guid id)
        {
            var books = await _bookStore.GetBooksAsync(_path);
            foreach (var item in books)
            {
                if (id == item.Id)
                {
                    return item;
                }
            }
            return NotFound();
        }

        [HttpPost]
        public async Task Post([FromBody] BookDTO bookDto)
        {
            var newBook = new Book()
            {
                Name = bookDto.Name,
                Author = bookDto.Author,
                Pages = bookDto.Pages,
                Popularity = bookDto.Popularity,
                Id = Guid.NewGuid()
            };

            var books = await _bookStore.GetBooksAsync(_path);
            books.Add(newBook);
            await _bookStore.SaveBooksAsync(books, _path);
        }

        [HttpPut("{id:guid}")]
        public async Task Put([FromBody] BookDTO bookDto, [FromRoute] Guid id)
        {
            var books = await _bookStore.GetBooksAsync(_path);
            foreach (var item in books)
            {
                if (item.Id == id)
                {
                    item.Name = bookDto.Name;
                    item.Author = bookDto.Author;
                    item.Pages = bookDto.Pages;
                    item.Popularity = bookDto.Popularity;
                }
            }

            await _bookStore.SaveBooksAsync(books, _path);
        }

        [HttpDelete("{id:guid}")]
        public async Task Delete([FromRoute] Guid id)
        {
            var books = await _bookStore.GetBooksAsync(_path);
            foreach (var item in books.ToList())
            {
                if (item.Id == id)
                {
                    books.Remove(item);
                }
                else
                {
                    NotFound();
                }
            }

            await _bookStore.SaveBooksAsync(books, _path);
        }
    }
}
