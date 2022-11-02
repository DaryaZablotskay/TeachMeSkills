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
        public Controller(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet("all")]
        public List<Book> GetAll()
        {
            using (StreamReader streamReader = new StreamReader(_config.GetValue<string>("Path1")))
            {
                var json = streamReader.ReadToEnd();
                return JsonConvert.DeserializeObject<List<Book>>(json);
            }
        }

        [HttpGet("one/{id}")]
        public Book GetOne(Guid id)
        {
            using (StreamReader streamReader = new StreamReader(_config.GetValue<string>("Path1")))
            {
                var json = streamReader.ReadToEnd();
                var books = JsonConvert.DeserializeObject<List<Book>>(json);
                foreach (var item in books)
                {
                    if (id == item.Id)
                    {
                        return item;
                    }
                }
                return null;
            }
        }

        [HttpPost("add")]
        public void Post([FromBody] Book book)
        {
            List<Book> books = new List<Book>();
            var newBook = new Book() { Name = book.Name, Author = book.Author, Id = book.Id, Pages = book.Pages, Popularity = book.Popularity };

            using (StreamReader streamReader = new StreamReader(_config.GetValue<string>("Path1")))
            {
                var json = streamReader.ReadToEnd();
                books = JsonConvert.DeserializeObject<List<Book>>(json);
            }

            using (StreamWriter streamWriter = new StreamWriter(_config.GetValue<string>("Path1")))
            {
                books.Add(newBook);
                var json = JsonConvert.SerializeObject(books, Formatting.Indented);
                streamWriter.WriteLine(json);
            }
        }

        [HttpDelete("delete/{id}")]
        public void Delete(Guid id)
        {
            List<Book> books = new List<Book>();
            using (StreamReader streamReader = new StreamReader(_config.GetValue<string>("Path1")))
            {
                var json = streamReader.ReadToEnd();
                books = JsonConvert.DeserializeObject<List<Book>>(json);
            }
            using (StreamWriter streamWriter = new StreamWriter(_config.GetValue<string>("Path1")))
            {
               
                for(int i=0; i<books.Count; i++)
                {
                    if (books[i].Id == id)
                    {
                        books.Remove(books[i]);
                    }
                }
                var json = JsonConvert.SerializeObject(books, Formatting.Indented);
                streamWriter.WriteLine(json);
            }
        }
    }
}
