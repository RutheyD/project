namespace LibreryProject.Models
{
    public enum Ecategory
    {
        children,
        teenage,
        adult
    }
    public class Book
    {
        public static int codeBook = 1;

        public int Code { get; } = codeBook++;
        public string Name { get; set; }
        public Ecategory Category { get; set; }
        public string Author { get; set; }
        public bool IsBorrowing { get; set; }


    }
}
