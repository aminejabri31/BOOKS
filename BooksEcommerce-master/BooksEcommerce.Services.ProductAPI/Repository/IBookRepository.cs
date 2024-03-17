using BooksEcommerce.Services.ProductAPI.Models.Dto;

namespace BooksEcommerce.Services.ProductAPI.Repository
{
    public interface IBookRepository
    {
        Task<IEnumerable<BookDto>> GetProducts();
        Task<BookDto> GetProductById(int Id);
        Task<BookDto> GetProductByTitle(string Title);
        Task<BookDto> UpdateProduct(BookDto bookDto);
        Task<BookDto> CreateProduct(BookDto bookDto);
        Task<bool> DeleteProduct(int Id);
    }
}
