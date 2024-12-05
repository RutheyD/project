using Library.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data
{
    public class DataContext:DbContext
    {

        public DbSet<Book> BookList { get; set; }
        public DbSet<Subscribe> SubscribeList { get; set; }
        public DbSet<Borrow> BorrowList { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Library_db");
        }


        //List<Book> BookList { get; set; } = new List<Book>() { new Book {Name="Dudi&Udi",Category=Ecategory.children,Author="Lion",IsBorrowing=false },
        //new Book {Name="Shatul",Category=Ecategory.adult,Author="Yona Sapir",IsBorrowing=false },
        //new Book {Name="Nan",Category=Ecategory.teenage,Author="Lea Frid",IsBorrowing=false }
        //};
        //List<Subscribe> SubscribeList { get; set; } = new List<Subscribe>(){ new Subscribe() {Id="327978197",Name="Ruti Cohen" ,Address="Rabbi Akiva 12 Bnei Brak", Phone="0504126125",IsActive=true},
        //new Subscribe() {Id="324569587",Name="Tamar Man" ,Address="Hazon Hish 83 Bnei Brak", Phone="0534556998",IsActive=true},
        //    new Subscribe() {Id="221118197",Name="Shoshi Tep" ,Address="Uziel 4 Bnei Brak", Phone="0504126555",IsActive=true}};

        //List<Borrow> BorrowList { get; set; } = new List<Borrow>();
        //public DataContext()
        //{
        //    BookList = new List<Book>()
        //    { new Book {Name="Dudi&Udi",Category=Ecategory.children,Author="Lion",IsBorrowing=false },
        //    new Book {Name="Shatul",Category=Ecategory.adult,Author="Yona Sapir",IsBorrowing=false },
        //    new Book {Name="Nan",Category=Ecategory.teenage,Author="Lea Frid",IsBorrowing=false }};

        //    SubscribeList = new List<Subscribe>() { new Subscribe() {Id="327978197",Name="Ruti Cohen" ,Address="Rabbi Akiva 12 Bnei Brak", Phone="0504126125",IsActive=true},
        //     new Subscribe() {Id="324569587",Name="Tamar Man" ,Address="Hazon Hish 83 Bnei Brak", Phone="0534556998",IsActive=true},
        //    new Subscribe() {Id="221118197",Name="Shoshi Tep" ,Address="Uziel 4 Bnei Brak", Phone="0504126555",IsActive=true}};

        //    BorrowList = new List<Borrow>();
        //}


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
