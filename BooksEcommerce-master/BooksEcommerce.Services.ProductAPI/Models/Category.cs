using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksEcommerce.Services.ProductAPI.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Name")]
        public string Name { get; set; }

       
    }
}
