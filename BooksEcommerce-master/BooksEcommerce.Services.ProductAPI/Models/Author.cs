using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksEcommerce.Services.ProductAPI.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Full Name")]
       
        public string FullName { get; set; }

        [ForeignKey("Authorid")]
        public List<string> ListBookTitels { get; set; }
    }
}
