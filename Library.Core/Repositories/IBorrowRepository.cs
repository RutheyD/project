using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Repositories
{
    public interface IBorrowRepository
    {
        List<Borrow> GetAll();
        List<Borrow> GetBorrowesByIdOfSubscriber(string? id, string? name);
        List<Borrow> GetBorrowesByCodeOfBook(int code);
        void BorrowingBook(int bookId, string subscriberId);
        void ReturningBook(int bookId, string subscriberId);
    }
}
