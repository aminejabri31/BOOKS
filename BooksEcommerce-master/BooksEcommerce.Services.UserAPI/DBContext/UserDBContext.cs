using BooksEcommerce.Services.UserAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BooksEcommerce.Services.UserAPI.DBContext
{
    public class UserDBContext : DbContext
    {
        public UserDBContext(DbContextOptions options) : base(options) { }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
