using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Repositories
{
    public interface IBookRepository
    {
         List<Book> GetAllR();
         Book GetBookByCodeR(int code);
        List<Book> GetBooksByNameR(string name);
         void AddBookR(Book book);
        void UpdatBookR(int code, Book book);
        void DeleteBookR(int code);


    }
}
