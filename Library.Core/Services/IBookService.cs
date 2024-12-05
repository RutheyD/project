using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Services
{
    public interface IBookService
    {
         List<Book> GetAllS();
         Book GetBookByCodeS(int code);
        List<Book> GetBooksByNameS(string name);
        void AddBookS(Book book);
        void UpdatBookS(int code, Book book);
        void DeleteBookS(int code);

    }
}
