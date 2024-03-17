

using BooksEcommerce.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using static System.Net.WebRequestMethods;


namespace BooksEcommerce.Services.ProductAPI.DBContext
{
    public class BookDBContext : DbContext
    {


        public BookDBContext(DbContextOptions options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Random rndm = new Random();
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "Title1",
                    ISBN = "3",
                    Description = "Description1",
                    Authorid = 1,
                    Price = 200,
                    ImageURL = "https://artisanmc.blob.core.windows.net/artisana/1.jpg",
                    ListCategories = new List<string> { "Categories1", "Categories2", "Categories3", "Categories4" },
                    InStock = 10
                },
                new Book
                {
                    Id = 2,
                    Title = "Title2",
                    ISBN = "5",
                    Description = "Description2",
                    Authorid = 1,
                    Price = 210,
                    ImageURL = "https://artisanmc.blob.core.windows.net/artisana/2.jpg",
                    ListCategories = new List<string> { "Categories5", "Categories2", "Categories6", "Categories7" },
                    InStock = 20
                },
                new Book
                {
                    Id = 3,
                    Title = "Title3",
                    ISBN = "4",
                    Description = "Description3",
                    Authorid = 1,
                    Price = 220,
                    ImageURL = "https://artisanmc.blob.core.windows.net/artisana/3.jpg",
                    ListCategories = new List<string> { "Categories1", "Categories5", "Categories8", "Categories9" },
                    InStock = 30
                },
                new Book
                {
                    Id = 4,
                    Title = "Title4",
                    ISBN = "1",
                    Description = "Description4",
                    Authorid = 2,
                    Price = 230,
                    ImageURL = "https://artisanmc.blob.core.windows.net/artisana/4.jpg",
                    ListCategories = new List<string> { "Categories3", "Categories5", "Categories10", "Categories2" },
                    InStock = 30
                },
                new Book
                {
                    Id = 5,
                    Title = "Title5",
                    ISBN = "2",
                    Description = "Description5",
                    Authorid = 2,
                    Price = 220,
                    ImageURL = "https://artisanmc.blob.core.windows.net/artisana/5.jpg",
                    ListCategories = new List<string> { "Categories3", "Categories5", "Categories8", "Categories12" },
                    InStock = 10
                },
                new Book
                {
                    Id = 6,
                    Title = "Title6",
                    ISBN = "3",
                    Description = "Description6",
                    Authorid = 2,
                    Price = 220,
                    ImageURL = "https://artisanmc.blob.core.windows.net/artisana/6.jpg",
                    ListCategories = new List<string> { "Categories11", "Categories6", "Categories4", "Categories1" },
                    InStock = 10
                },
                new Book
                {
                    Id = 7,
                    Title = "Title7",
                    ISBN = "2",
                    Description = "Description7",
                    Authorid = 3,
                    Price = 200,
                    ImageURL = "https://artisanmc.blob.core.windows.net/artisana/7.jpg",
                    ListCategories = new List<string> { "Categories10", "Categories3", "Categories9", "Categories12" },
                    InStock = 10
                },
                new Book
                {
                    Id = 8,
                    Title = "Title8",
                    ISBN = "3",
                    Description = "Description8",
                    Authorid = 3,
                    Price = 280,
                    ImageURL = "https://artisanmc.blob.core.windows.net/artisana/8.jpg",
                    ListCategories = new List<string> { "Categories7", "Categories1", "Categories12" },
                    InStock = 10
                },
                new Book
                {
                    Id = 9,
                    Title = "Title9",
                    ISBN = "3",
                    Description = "Description5",
                    Authorid = 3,
                    Price = 290,
                    ImageURL = "https://artisanmc.blob.core.windows.net/artisana/9.jpg",
                    ListCategories = new List<string> { "Categories3", "Categories5" },
                    InStock = 10
                }
            );
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id=1,
                    Name= "Categories1"
                },
                new Category
                {
                    Id = 2,
                    Name = "Categories2"
                },
                new Category
                {
                    Id = 3,
                    Name = "Categories3"
                },
                new Category
                {
                    Id = 4,
                    Name = "Categories4"
                },
                new Category
                {
                    Id = 5,
                    Name = "Categories5"
                },
                new Category
                {
                    Id = 6,
                    Name = "Categories6"
                },
                new Category
                {
                    Id = 7,
                    Name = "Categories7"
                },
                new Category
                {
                    Id = 8,
                    Name = "Categories8"
                },
                new Category
                {
                    Id = 9,
                    Name = "Categories9"
                },
                new Category
                {
                    Id = 10,
                    Name = "Categories10"
                },
                new Category
                {
                    Id = 11,
                    Name = "Categories11"
                }, 
                new Category
                {
                    Id = 12,
                    Name = "Categories12"
                }
                );
            modelBuilder.Entity<Author>().HasData(
                new Author
                {
                    Id=1,
                    FullName="Author1",
                    ListBookTitels= new List<string> {"Title1", "Title2", "Title3" }

                },
                new Author
                {
                    Id = 2,
                    FullName = "Author2",
                    ListBookTitels = new List<string> { "Title4", "Title5", "Title6" }

                },
                new Author
                {
                    Id = 3,
                    FullName = "Author3",
                    ListBookTitels = new List<string> { "Title7", "Title8", "Title9" }

                });

        }

    }


}
        



