using LibreryProject.Models;

namespace LibreryProject.Lists
{
    public class Lists_Of_The_Librery:IDataLists
    {
        public Lists_Of_The_Librery()
        {
            BookList=new List<Book>();
            SubscribeList=new List<Subscribe>();
            BorrowList=new List<Borrow>();
        }
        public  List<Book> BookList { get; set; }
        public List<Subscribe> SubscribeList { get; set; }
        public List<Borrow> BorrowList { get; set; }

        //public  List<Book> Books = new List<Book>() { new Book {Name="Dudi&Udi",Category=Ecategory.children,Author="Lion",IsBorrowing=false },
        //new Book {Name="Shatul",Category=Ecategory.adult,Author="Yona Sapir",IsBorrowing=false },
        //new Book {Name="Nan",Category=Ecategory.teenage,Author="Lea Frid",IsBorrowing=false }
        //};

        //public  List<Subscribe> Subscriptions = new List<Subscribe>() { new Subscribe() {Id="327978197",Name="Ruti Cohen" ,Address="Rabbi Akiva 12 Bnei Brak", Phone="0504126125",IsActive=true},
        //new Subscribe() {Id="324569587",Name="Tamar Man" ,Address="Hazon Hish 83 Bnei Brak", Phone="0534556998",IsActive=true},
        //    new Subscribe() {Id="221118197",Name="Shoshi Tep" ,Address="Uziel 4 Bnei Brak", Phone="0504126555",IsActive=true}};

        //public  List<Borrow> Borrows = new List<Borrow>();



    }
}
