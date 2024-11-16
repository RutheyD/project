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
        private readonly IDataLists _allLists;
        public BookController(IDataLists context)
        {
            _allLists = context;
        }

        // GET: api/<BookController>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _allLists.BookList;
        }

        // GET api/<BookController>/5
        //??????????????????????????
        //מחזיר ספר עפ מזהה
        [HttpGet("{code}")]
        public ActionResult<Book> Get(int code)
        {
            Book book = _allLists.BookList.FirstOrDefault(b => b.Code == code);
            if (book == null)
                return NotFound();
            return Ok(book);

        }
        //מחזיר רשימה של כל הספרים ששמם הוא השם שנשלח
         [HttpGet("{name}name")]
        public ActionResult<Book> Get( string name)
        {
            List<Book> book = _allLists.BookList.Where(b => b.Name == name).ToList();
            if (book == null)
                return NotFound();
            return Ok(book);

        }
        // POST api/<BookController>
        //הוספת ספר מסוים
        [HttpPost]
        public void Post([FromBody] Book book)
        {
            _allLists.BookList.Add(book);
        }

        // PUT api/<BookController>/5
        //מעדכן ספר
        [HttpPut("{code}")]
        public void Put(int code, [FromBody] Book book)
        {
            Book tmpBook = _allLists.BookList.FirstOrDefault(book => book.Code == code);
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
            Book book = _allLists.BookList.FirstOrDefault(book => book.Code == code);
            if (book != null)
                _allLists.BookList.Remove(book);
        }

    }
}
