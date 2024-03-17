using BookEcommerce.Web.Models;


namespace BookEcommerce.Web.Service.IService
{
    public interface IProductService:IBaseService
    {

        Task<T> GetAllBooks<T>();
        Task<T> GetBookByIdAsync<T>(int id);
        
        Task<T> GetBooksByCategoryAsync<T>(List<CategoryDto> categoryDto);
        Task<T> GetBookByTitleAsync<T>(string Title);
        Task<T> GetBooksByAutherAsync<T>(AuthorDto authorDto);
        Task<T> CreateProductAsync<T>(BookDto book);
        Task<T> CreateCategoryAsync<T>(CategoryDto categoryDto);
        Task<T> CreateAuthorAsync<T>(AuthorDto authorDto);
        Task<T> DeleteBookAsync<T>(int id, string token);
        Task<T> UpdateProductAsync<T>(BookDto book);
        Task<T> GetAllAutherAsync<T>();
        Task<T> GetAutherByNameAsync<T>(string name);
        Task<T> GetCategoryListAsync<T>();
        Task<T> GetCategoryByNameAsync<T>(string name);
        //Task<T> GetAutherByIdAsync<T>(int id);
    }
}
