using AutoMapper;
using BooksEcommerce.Services.ProductAPI.Models;
using BooksEcommerce.Services.ProductAPI.Models.Dto;

namespace BooksEcommerce.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Book, BookDto>();
                config.CreateMap<BookDto, Book>();
                config.CreateMap<Author, AuthorDto>();
                config.CreateMap<AuthorDto, Author>();
                config.CreateMap<Category, CategoryDto>();
                config.CreateMap<CategoryDto, Category>();
            }
                );
            return mappingConfig;
        }
    }
}
