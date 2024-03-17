using System.ComponentModel.DataAnnotations;

namespace BooksEcommerce.Services.UserAPI.Models.Dto
{
    public class AccountDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public DateTime Created { get; set; }
        [Required]
        public RoleType Role { get; set; }
        public ApplicationUser User { get; set; }

        
    }
}
