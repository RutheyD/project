using Library.Core.Models;
using Library.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Librery.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        //private readonly IDataContext _allLists;
        //public BookController(IDataContext context)
        //{
        //    _allLists = context;
        //}
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService= bookService;
        }

        // GET: api/<BookController>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
          return  _bookService.GetAllS();
        }

        // GET api/<BookController>/5
        //מחזיר ספר עפ מזהה
        [HttpGet("{code}")]
        public ActionResult<Book> Get(int code)
        {
            var book = _bookService.GetBookByCodeS(code);
            if (book == null)
                return NotFound();
            return Ok(book);

        }
        //מחזיר רשימה של כל הספרים ששמם הוא השם שנשלח
        [HttpGet("{name}name")]
        public ActionResult<Book> Get(string name)
        {
            List<Book> book = _bookService.GetBooksByNameS(name);
            if (!book.Any())
                return NotFound();
            return Ok(book);

        }
        // POST api/<BookController>
        //הוספת ספר מסוים
        [HttpPost]
        public void Post([FromBody] Book book)
        {
           _bookService.AddBookS(book);
           
        }

        // PUT api/<BookController>/5
        //מעדכן ספר
        [HttpPut("{code}")]
        public void Put(int code, [FromBody] Book book)
        {
            _bookService.UpdatBookS(code, book);
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{code}")]
        public void Delete(int code)
        {
            _bookService.DeleteBookS(code);
        }

    }
}
