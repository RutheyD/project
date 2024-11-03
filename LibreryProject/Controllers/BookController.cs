using LibreryProject.Lists;
using LibreryProject.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibreryProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        public BookController()
        {

        }

        // GET: api/<BookController>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return Lists_Of_The_Librery.Books;
        }

        // GET api/<BookController>/5
        //??????????????????????????
        [HttpGet("{code}")]
        public ActionResult<Book> Get( int code)
        {
            Book book = Lists_Of_The_Librery.Books.FirstOrDefault(b => b.Code == code);
            if (book == null)
                return NotFound();
            return Ok(book);

        }
         [HttpGet("{name}name")]
        public ActionResult<Book> Get( string name)
        {
            List<Book> book = Lists_Of_The_Librery.Books.Where(b => b.Name == name).ToList();
            if (book == null)
                return NotFound();
            return Ok(book);

        }
        // POST api/<BookController>
        [HttpPost]
        public void Post([FromBody] Book book)
        {
            Lists_Of_The_Librery.Books.Add(book);
        }

        // PUT api/<BookController>/5
        [HttpPut("{code}")]
        public void Put(int code, [FromBody] Book book)
        {
            Book tmpBook = Lists_Of_The_Librery.Books.FirstOrDefault(book => book.Code == code);
            if (tmpBook != null)
            {
                tmpBook.Author = book.Author;
                tmpBook.Name = book.Name;
                tmpBook.Category = book.Category;
                tmpBook.IsBorrowing = book.IsBorrowing;
            }
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{code}")]
        public void Delete(int code)
        {
            Book book = Lists_Of_The_Librery.Books.FirstOrDefault(book => book.Code == code);
            if (book != null)
                Lists_Of_The_Librery.Books.Remove(book);
        }

    }
}
