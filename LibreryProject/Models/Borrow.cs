namespace LibreryProject.Models
{
    public class Borrow
    {
        public DateTime BorrowDate { get; set; }
        public DateTime ?ReturnDate { get; set; }
        public Subscribe ?Subscriber { get; set; }
        public Book ?BorrowedBook { get; set; }
        public bool IsReturned { get; set; }
    }
}
