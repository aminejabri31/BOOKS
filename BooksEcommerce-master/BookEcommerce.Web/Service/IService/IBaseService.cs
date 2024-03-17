using BooksEcommerce.Web;

namespace BookEcommerce.Web.Service.IService
{
    public interface IBaseService : IDisposable
    {
        ReponseDto reponseModel { get; set; }
        Task<T> SendAsync<T>(ApiRequest apiRequest);

    }
}
