using BooksEcommerce.Services.ProductAPI.Models.Dto;

namespace BooksEcommerce.Services.ProductAPI.Repository
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<BookDto>> GetBooksByCategory(List<CategoryDto> categoryDto);
        Task<IEnumerable<CategoryDto>> GetCategoryList();
        Task<CategoryDto> CreateCategory(CategoryDto categoryDto);
        Task<CategoryDto> GetCategoryByName(string name);
        Task<CategoryDto> GetCategoryById(int Id);

    }
}
