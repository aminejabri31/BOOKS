namespace BookEcommerce.Web.Models
{
    public class BookDto
    {
        public int Id { get; set; }


        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Description { get; set; }

        public int Authorid { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public List<string> ListCategories { get; set; }

        public int InStock { get; set; }
    }
}
