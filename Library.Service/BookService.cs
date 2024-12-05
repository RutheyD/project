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
    public class BookService:IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository=bookRepository;
        }
        public List<Book> GetAllS() => _bookRepository.GetAllR();
        public Book GetBookByCodeS(int code) => _bookRepository.GetBookByCodeR(code);
        public List<Book> GetBooksByNameS(string name) => _bookRepository.GetBooksByNameR(name);
        public void AddBookS(Book book)=> _bookRepository.AddBookR(book);
        public void UpdatBookS(int code, Book book)=> _bookRepository.UpdatBookR(code,book);
        public void DeleteBookS(int code)=> _bookRepository.DeleteBookR(code);

    }
}
