using LibreryProject.Controllers;
using LibreryProject.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace LibreryUnitTest
{
    public class BookControllesTests
    {
        private readonly BookController _controller;
        public BookControllesTests()
        {
            FakeLists fakeLists = new FakeLists();
            _controller = new BookController(fakeLists);
        }
        [Fact]
        public void Get_ReturnAll()
        {
            
            var controller =_controller;
            var resurlt = controller.Get();
            Assert.IsType<List<Book>>(resurlt);
        }
        [Fact]
        public void GetIdBook_ReturnBook()
        {
            int bookId = 1;
            var controller = _controller;
            var result = controller.Get(bookId);
            Assert.IsType<OkObjectResult>(result);
        }
        
    }
}