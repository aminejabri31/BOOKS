using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksEcommerce.Services.ProductAPI.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(55)]
        [ForeignKey("Authorid")]
        public string Title { get; set; }


        [Required]
        public string ISBN { get; set; }

        public string Description { get; set; }

        [Required]
        [Display(Name = "Author")]
        public int Authorid { get; set; }


        [Required]
        [Range(1, 10000)]
        public double Price { get; set; }

        
        [Display(Name = "Image")]
        
        public string ImageURL { get;  set; }
        
        [Required]
        [Display(Name = "Category")]
        [ForeignKey("Name")]
        public List<string> ListCategories { get; set; }

        

        [Range(0, 100)]
        public int InStock { get; set; }
    }
}
