using Library.Core.Models;
using Library.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repositories
{
    public class BookRepository:IBookRepository
    {
        private readonly DataContext _context;
        public BookRepository(DataContext context)
        {
            _context =context;
            
        }
        public List<Book> GetAllR() => _context.BookList.ToList();
        public Book GetBookByCodeR(int code) => _context.BookList.FirstOrDefault(b => b.Code == code);
        public List<Book> GetBooksByNameR(string name) => _context.BookList.Where(b => b.Name == name).ToList();

        public void AddBookR(Book book) => _context.BookList.Add(book);
        public void UpdatBookR(int code, Book book)
        {
            var BookToUpdate = _context.BookList.FirstOrDefault(b => b.Code == code);
            
            if (BookToUpdate != null)
            {
                BookToUpdate.Author = book.Author;
                BookToUpdate.Name = book.Name;
                BookToUpdate.Category = book.Category;
                BookToUpdate.IsBorrowing = book.IsBorrowing;
            }
        }
        public void DeleteBookR(int code)
        {
            var BookToDelete = _context.BookList.FirstOrDefault(b => b.Code == code);
            if (BookToDelete != null)
                _context.BookList.Remove(BookToDelete);
        }
    }
}
