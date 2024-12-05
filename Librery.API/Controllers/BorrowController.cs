
using Library.Core.Models;
using Library.Core.Services;
using Microsoft.AspNetCore.Mvc;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Librery.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BorrowController : ControllerBase
    {
        private readonly IBorrowService _borrowService;
        public BorrowController(IBorrowService borrowService)
        {
            _borrowService = borrowService;
        }
        // GET: api/<BorrowCollector>
        [HttpGet]
        public IEnumerable<Borrow> Get()
        {
            return _borrowService.GetAll();
        }

        //מחזיר את ההשאלות של אדם מסוים
        // GET api/<BorrowCollector>/5
        [HttpGet("with")]
        public ActionResult<Borrow> Get([FromQuery] string? id, [FromQuery] string? name)
        {
           List< Borrow> borrow = _borrowService.GetBorrowesByIdOfSubscriber(id, name); 
            if(!borrow.Any()) 
                return NotFound();
            return Ok(borrow);
        }
        //מחזיר את ההשאלות של ספר מסוים
        // GET api/<BorrowCollector>/5
        [HttpGet("{id}current book")]
        public ActionResult<Borrow> Get([FromQuery] int BookID)
        {
            List<Borrow> borrow = _borrowService.GetBorrowesByCodeOfBook(BookID);
            if (!borrow.Any())
                return NotFound();
            return Ok(borrow);

        }

        //[HttpGet("{code}")]
        //public bool GET(int code)
        //{
        //    if (Lists_Of_The_Librery.Books.FirstOrDefault(b => b.Code == code).IsBorrowing == false)
        //        return true;
        //    return false;
        //}

        // POST api/<BorrowCollector>
        //[HttpPost]
        //public void Post([FromBody] Borrow borrow)
        //{
        //    Lists_Of_The_Librery.Borrows.Add(borrow);
        //}

        //השאלת ספר
        [HttpPost]
        public void Post(int bookId, string subscriberId)
        {
            _borrowService.BorrowingBook(bookId, subscriberId);

        }


        //החזרת ספר
        // PUT api/<BorrowCollector>/5
        [HttpPut("{bookId}/{subscriberId}")]
        public void Put(int bookId, string subscriberId)
        {
            _borrowService.ReturningBook(bookId, subscriberId);
        }

        // DELETE api/<BorrowCollector>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{

        //}
    }
}
