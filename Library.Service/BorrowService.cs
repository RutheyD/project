using Library.Core.Models;
using Library.Core.Repositories;
using Library.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service
{
    public class BorrowService : IBorrowService
    {
        private readonly IBorrowRepository _borrowRepository;
        public BorrowService(IBorrowRepository borrowRepository)
        {
            _borrowRepository = borrowRepository;
        }

        public List<Borrow> GetAll() => _borrowRepository.GetAll();
        public List<Borrow> GetBorrowesByIdOfSubscriber(string? id, string? name) => _borrowRepository.GetBorrowesByIdOfSubscriber(id, name);       
        public List<Borrow> GetBorrowesByCodeOfBook(int code) => _borrowRepository.GetBorrowesByCodeOfBook(code);
        public void BorrowingBook(int bookId, string subscriberId) => _borrowRepository.BorrowingBook(bookId, subscriberId);
        public void ReturningBook(int bookId, string subscriberId)=>_borrowRepository.ReturningBook(bookId, subscriberId);
    }
}
