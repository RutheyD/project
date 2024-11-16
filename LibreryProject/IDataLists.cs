using LibreryProject.Models;

namespace LibreryProject
{
    public  interface IDataLists
    {
       List<Book> BookList { get; set; }
       List<Subscribe> SubscribeList { get; set; }
       List<Borrow> BorrowList { get; set; }

       

    }
}
