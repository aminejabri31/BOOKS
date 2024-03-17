﻿// <auto-generated />
using BooksEcommerce.Services.ProductAPI.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BooksEcommerce.Services.ProductAPI.Migrations
{
    [DbContext(typeof(BookDBContext))]
    partial class BookDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BooksEcommerce.Services.ProductAPI.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullName = "Author1"
                        },
                        new
                        {
                            Id = 2,
                            FullName = "Author2"
                        },
                        new
                        {
                            Id = 3,
                            FullName = "Author3"
                        });
                });

            modelBuilder.Entity("BooksEcommerce.Services.ProductAPI.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Authorid")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InStock")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Authorid = 1,
                            Description = "Description1",
                            ISBN = "3",
                            ImageURL = "https://artisanmc.blob.core.windows.net/artisana/1.jpg",
                            InStock = 10,
                            Price = 200.0,
                            Title = "Title1"
                        },
                        new
                        {
                            Id = 2,
                            Authorid = 1,
                            Description = "Description2",
                            ISBN = "5",
                            ImageURL = "https://artisanmc.blob.core.windows.net/artisana/2.jpg",
                            InStock = 20,
                            Price = 210.0,
                            Title = "Title2"
                        },
                        new
                        {
                            Id = 3,
                            Authorid = 1,
                            Description = "Description3",
                            ISBN = "4",
                            ImageURL = "https://artisanmc.blob.core.windows.net/artisana/3.jpg",
                            InStock = 30,
                            Price = 220.0,
                            Title = "Title3"
                        },
                        new
                        {
                            Id = 4,
                            Authorid = 2,
                            Description = "Description4",
                            ISBN = "1",
                            ImageURL = "https://artisanmc.blob.core.windows.net/artisana/4.jpg",
                            InStock = 30,
                            Price = 230.0,
                            Title = "Title4"
                        },
                        new
                        {
                            Id = 5,
                            Authorid = 2,
                            Description = "Description5",
                            ISBN = "2",
                            ImageURL = "https://artisanmc.blob.core.windows.net/artisana/5.jpg",
                            InStock = 10,
                            Price = 220.0,
                            Title = "Title5"
                        },
                        new
                        {
                            Id = 6,
                            Authorid = 2,
                            Description = "Description6",
                            ISBN = "3",
                            ImageURL = "https://artisanmc.blob.core.windows.net/artisana/6.jpg",
                            InStock = 10,
                            Price = 220.0,
                            Title = "Title6"
                        },
                        new
                        {
                            Id = 7,
                            Authorid = 3,
                            Description = "Description7",
                            ISBN = "2",
                            ImageURL = "https://artisanmc.blob.core.windows.net/artisana/7.jpg",
                            InStock = 10,
                            Price = 200.0,
                            Title = "Title7"
                        },
                        new
                        {
                            Id = 8,
                            Authorid = 3,
                            Description = "Description8",
                            ISBN = "3",
                            ImageURL = "https://artisanmc.blob.core.windows.net/artisana/8.jpg",
                            InStock = 10,
                            Price = 280.0,
                            Title = "Title8"
                        },
                        new
                        {
                            Id = 9,
                            Authorid = 3,
                            Description = "Description5",
                            ISBN = "3",
                            ImageURL = "https://artisanmc.blob.core.windows.net/artisana/9.jpg",
                            InStock = 10,
                            Price = 290.0,
                            Title = "Title9"
                        });
                });

            modelBuilder.Entity("BooksEcommerce.Services.ProductAPI.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Categories1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Categories2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Categories3"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Categories4"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Categories5"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Categories6"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Categories7"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Categories8"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Categories9"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Categories10"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Categories11"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Categories12"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
