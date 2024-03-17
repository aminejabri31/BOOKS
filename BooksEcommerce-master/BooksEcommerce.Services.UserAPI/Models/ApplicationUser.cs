

using System.ComponentModel.DataAnnotations;

namespace BooksEcommerce.Services.UserAPI.Models
{
    public class ApplicationUser
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(55)]
        public string UserName { get; set; }
        
        [MaxLength(55)]
        public string LastName { get; set; } 
        public string PhoneNumber { get; set; }
        public DateTime JoinedAt { get; set; } = DateTime.Now;
        public string AddressUser { get; set; }
        public string ImageURL { get; set; }

        //public virtual PaymentMethod PaymentMethod { get; set; }
        //public virtual ICollection<Book> BookList { get; set; } for product alredy ordres
        //public virtual ICollection<Invoice> Invoices { get; set; } for the orders
    }
}
