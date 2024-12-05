using System.ComponentModel.DataAnnotations;

namespace Library.Core.Models
{
    public class Borrow
    {
        [Key]
        public int IdBorrow { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public Subscribe? Subscriber { get; set; }
        public Book? BorrowedBook { get; set; }
        public bool IsReturned { get; set; }
    }
}
