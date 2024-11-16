using LibreryProject;
using LibreryProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreryUnitTest
{
    internal class FakeLists:IDataLists
    {
        public FakeLists()
        {
            BookList = new List<Book>{ new Book {Name="Dudi&Udi",Category=Ecategory.children,Author="Lion",IsBorrowing=false },
            new Book {Name="Shatul",Category=Ecategory.adult,Author="Yona Sapir",IsBorrowing=false },
            new Book {Name="Nan",Category=Ecategory.teenage,Author="Lea Frid",IsBorrowing=false }
                     };
            SubscribeList = new List<Subscribe>();
            BorrowList = new List<Borrow>();
        }
        public List<Book> BookList { get; set; }
        public List<Subscribe> SubscribeList { get; set; }
        public List<Borrow> BorrowList { get; set; }

        //public static List<Book> Books = new List<Book>() { new Book {Name="Dudi&Udi",Category=Ecategory.children,Author="Lion",IsBorrowing=false },
        //new Book {Name="Shatul",Category=Ecategory.adult,Author="Yona Sapir",IsBorrowing=false },
        //new Book {Name="Nan",Category=Ecategory.teenage,Author="Lea Frid",IsBorrowing=false }
        //};

        //public static List<Subscribe> Subscriptions = new List<Subscribe>() { new Subscribe() {Id="327978197",Name="Ruti Cohen" ,Address="Rabbi Akiva 12 Bnei Brak", Phone="0504126125",IsActive=true},
        //new Subscribe() {Id="324569587",Name="Tamar Man" ,Address="Hazon Hish 83 Bnei Brak", Phone="0534556998",IsActive=true},
        //    new Subscribe() {Id="221118197",Name="Shoshi Tep" ,Address="Uziel 4 Bnei Brak", Phone="0504126555",IsActive=true}};

        //public static List<Borrow> Borrows = new List<Borrow>();


    }
}
