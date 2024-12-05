using System.ComponentModel.DataAnnotations;

namespace Library.Core.Models
{
    public class Subscribe
    {
        [Key]
        public int IdSubscribe { get; set; }
        public string SubscriberId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }
        // public List<Borrow> ?BorrowsList { get; set; }

    }
}
