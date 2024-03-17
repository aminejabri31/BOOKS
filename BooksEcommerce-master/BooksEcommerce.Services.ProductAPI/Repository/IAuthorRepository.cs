using BooksEcommerce.Services.ProductAPI.Models.Dto;

namespace BooksEcommerce.Services.ProductAPI.Repository
{
    public interface IAuthorRepository
    {
        Task<IEnumerable<BookDto>> GetBooksByAuther(AuthorDto authorDto);
        Task<AuthorDto> CreateAuthor(AuthorDto authorDto);
        Task<IEnumerable<AuthorDto>> GetAllAuther();
        Task<AuthorDto> GetAutherByName(string name);
        Task<AuthorDto> GetAutherById(int id);
    }
}
