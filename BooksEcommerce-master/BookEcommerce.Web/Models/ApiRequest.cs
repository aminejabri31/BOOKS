

using static BookEcommerce.Web.SD;

namespace BooksEcommerce.Web
{
    public class ApiRequest
    {
        public ApiType ApiType { get; set; }
        public string Url { get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; }

    }
}
