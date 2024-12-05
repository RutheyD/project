using Library.Core.Models;
using Library.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repositories
{
    public class BorrowRepository:IBorrowRepository
    {
        private readonly DataContext _context;
        public BorrowRepository(DataContext context)
        {
            _context = context;
        }

        public List<Borrow> GetAll() => _context.BorrowList.ToList();
        public List<Borrow>GetBorrowesByIdOfSubscriber( string? id,  string? name)=>_context.BorrowList.Where(sub => sub.Subscriber.SubscriberId == id || sub.Subscriber.Name == name).ToList();

        public List<Borrow> GetBorrowesByCodeOfBook(int code) 
        {
            return _context.BorrowList.Where(b => b.BorrowedBook.Code == code).ToList(); 
        } 
        public void BorrowingBook(int bookId, string subscriberId)
        {
            //Book ?book = _context.BookList.FirstOrDefault(b =>b.Code == bookId);
            //Subscribe ?subscribe = _context.SubscribeList.FirstOrDefault(p => p.Id == subscriberId);
            //if (subscribe != null && book != null && book.IsBorrowing == false)
            //{
            //    _context.BorrowList.Add(new Borrow { BorrowDate = DateTime.Today, Subscriber = subscribe, BorrowedBook = book, IsReturned = false });
            //    book.IsBorrowing = true;
            //}

        }
        public void ReturningBook(int bookId, string subscriberId) {
            Book ?book = _context.BookList.FirstOrDefault(b => b.Code == bookId);
            Subscribe ?subscribe = _context.SubscribeList.FirstOrDefault(p => p.SubscriberId == subscriberId);
            if (subscribe != null && book != null)
            {
                Borrow ?borrow = _context.BorrowList.FirstOrDefault(b => b.Subscriber.SubscriberId == subscriberId && b.BorrowedBook.Code == bookId);
                if (borrow != null)
                {
                    borrow.IsReturned = true;
                    borrow.ReturnDate = DateTime.Today;
                    book.IsBorrowing = false;
                }
            }
        }




    }
}
