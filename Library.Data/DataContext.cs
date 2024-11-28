using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data
{
    public class DataContext
    {
        List<Book> BookList { get; set; }
        List<Subscribe> SubscribeList { get; set; }
        List<Borrow> BorrowList { get; set; }


    }
}
