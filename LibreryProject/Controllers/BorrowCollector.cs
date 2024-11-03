using LibreryProject.Lists;
using LibreryProject.Models;
using Microsoft.AspNetCore.Mvc;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibreryProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BorrowCollector : ControllerBase
    {
        public BorrowCollector()
        {

        }
        // GET: api/<BorrowCollector>
        [HttpGet]
        public IEnumerable<Borrow> Get()
        {
            return Lists_Of_The_Librery.Borrows;
        }

        //מחזיר את ההשאלות של אדם מסוים
        // GET api/<BorrowCollector>/5
        [HttpGet("with")]
        public IEnumerable<Borrow> Get([FromQuery] string? id, [FromQuery] string? name)
        {
            return Lists_Of_The_Librery.Borrows.Where(sub => sub.Subscriber.Id == id || sub.Subscriber.Name == name).ToList();
        }
        //מחזיר את ההשאלות של ספר מסוים
        // GET api/<BorrowCollector>/5
        [HttpGet("{id}current book")]
        public ActionResult<Borrow> Get([FromQuery] int idBorrow)
        {
            Borrow borrow = Lists_Of_The_Librery.Borrows.FirstOrDefault(sub => sub.BorrowedBook.Code == idBorrow);
            if (borrow == null)
                return NotFound();
            return borrow;

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
        public void Post(string bookName, string subscriberId)
        {
            Book book1 = Lists_Of_The_Librery.Books.FirstOrDefault(b => b.Name == bookName);
            Subscribe subscribe = Lists_Of_The_Librery.Subscriptions.FirstOrDefault(p => p.Id == subscriberId);
            if (subscribe != null && book1 != null && book1.IsBorrowing == false)
            {
                Lists_Of_The_Librery.Borrows.Add(new Borrow { BorrowDate = DateTime.Today, Subscriber = subscribe, BorrowedBook = book1, IsReturned = false });
                book1.IsBorrowing = true;
            }

        }


        //החזרת ספר
        // PUT api/<BorrowCollector>/5
        [HttpPut("{bookId}/{subscriberId}")]
        public void Put(int bookId, string subscriberId)
        {
            Book book1 = Lists_Of_The_Librery.Books.FirstOrDefault(b => b.Code == bookId);
            Subscribe subscribe = Lists_Of_The_Librery.Subscriptions.FirstOrDefault(p => p.Id == subscriberId);
            if (subscribe != null && book1 != null)
            {
                Borrow borrow = Lists_Of_The_Librery.Borrows.FirstOrDefault(b => (b.Subscriber.Id == subscriberId) && (b.BorrowedBook.Code == bookId));
                if (borrow != null)
                {
                    borrow.IsReturned = true;
                    borrow.ReturnDate = DateTime.Today;
                    book1.IsBorrowing = false;
                }
            }
        }

        // DELETE api/<BorrowCollector>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{

        //}
    }
}
