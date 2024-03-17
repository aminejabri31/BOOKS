namespace BooksEcommerce.Web
{
    public class ReponseDto
    {
        public bool IsSuccess { get; set; } = true;
        public object Result { get; set; }
        public string DisplayMessage { get; set; } = "";
        public List<string> Errors { get; set; }
    }
}
