using BookEcommerce.Web.Models;
using BookEcommerce.Web.Service.IService;
using BooksEcommerce.Web;

namespace BookEcommerce.Web.Service
{
    public class ProductService : BaseService, IProductService
    {
        private readonly IHttpClientFactory _clientFactory;
        public ProductService(IHttpClientFactory httpClient) : base(httpClient)
        {
            _clientFactory = httpClient;
        }
        // Create 
        public async Task<T> CreateAuthorAsync<T>(AuthorDto authorDto)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = authorDto,
                Url = SD.ProductAPIBase + "/api/product/author",
                //AccessToken = token
            });
        }

        public async Task<T> CreateCategoryAsync<T>(CategoryDto categoryDto)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = categoryDto,
                Url = SD.ProductAPIBase + "/api/product/category",
                //AccessToken = token
            });
        }

        public async Task<T> CreateProductAsync<T>(BookDto book)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = book,
                Url = SD.ProductAPIBase + "/api/product/",
                //AccessToken = token
            });
        }
        //Delete
        public async Task<T> DeleteBookAsync<T>(int id, string token)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.DELETE,
                Url = SD.ProductAPIBase + "/api/product/" + id,
                // AccessToken = token
            });
        }
        //Get AUthors and Category 
        public async Task<T> GetCategoryByNameAsync<T>(string name)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.ProductAPIBase + "/api/product/category/"+ name,
                // AccessToken = token
            });
        }

        public async Task<T> GetCategoryListAsync<T>()
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.ProductAPIBase + "/api/product/category",
                // AccessToken = token
            });
            
        }
        public async Task<T> GetAllAutherAsync<T>()
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.ProductAPIBase + "/api/product/author",
                // AccessToken = token
            });

        }
        public async Task<T> GetAutherByNameAsync<T>(string name)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.ProductAPIBase + "/api/product/author/"+ name,
                // AccessToken = token
            });
        }
       /* public async Task<T> GetAutherByIdAsync<T>(int id)
        {

            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.ProductAPIBase + "/api/product/author/authorId/" + id,
                // AccessToken = token
            });
        */

        //Get Books
        public async Task<T> GetAllBooks<T>()
        {

            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.ProductAPIBase + "/api/product",
                // AccessToken = token
            });
        }

        

        public async Task<T> GetBookByIdAsync<T>(int id)
        {

            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.ProductAPIBase + "/api/product/"+id,
                // AccessToken = token
            });
        }

        public async Task<T> GetBookByTitleAsync<T>(string Title)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.ProductAPIBase + "/api/product/title/" + Title,
                // AccessToken = token
            });

        }

        public async Task<T> GetBooksByAutherAsync<T>(AuthorDto authorDto)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Data=authorDto,
                Url = SD.ProductAPIBase + "/api/product/author/" + authorDto,
                // AccessToken = token
            });
        }

        public async Task<T> GetBooksByCategoryAsync<T>(List<CategoryDto> categoryDto)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Data = categoryDto,
                Url = SD.ProductAPIBase + "/api/product/category/" + categoryDto,
                // AccessToken = token
            });
        }

        
        //Update
        public async Task<T> UpdateProductAsync<T>(BookDto book)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.PUT,
                Data = book,
                Url = SD.ProductAPIBase + "/api/product",
                //AccessToken = token
            });
        }
    }
}
