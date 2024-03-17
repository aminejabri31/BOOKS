using AutoMapper;
using BooksEcommerce.Services.ProductAPI.DBContext;
using BooksEcommerce.Services.ProductAPI.Models;
using BooksEcommerce.Services.ProductAPI.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace BooksEcommerce.Services.ProductAPI.Repository
{
    public class BookRepository:IBookRepository
    {
        private readonly BookDBContext _dbContext;
        private IMapper _mapper;
        public BookRepository(BookDBContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<BookDto> CreateProduct(BookDto bookDto)
        {
            Book book = new Book{
            Title = bookDto.Title,
            Description = bookDto.Description,
            Authorid = bookDto.Authorid,
            
            ISBN = bookDto.ISBN,
            InStock = bookDto.InStock,
            Price = bookDto.Price,
            ListCategories = bookDto.ListCategories,
                ImageURL = bookDto.ImageURL,
            
            };
            await _dbContext.Books.AddAsync(book);
            await _dbContext.SaveChangesAsync();
            return _mapper.Map<BookDto>(book);
        }

        public async Task<bool> DeleteProduct(int Id)
        {
            Book book = await _dbContext.Books.FindAsync(Id);
            if (book != null)
            {
                _dbContext.Books.Remove(book);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            return false;

        }
    

        public async Task<BookDto> GetProductById(int Id)
        {
            Book book = await _dbContext.Books.FindAsync(Id);
            return _mapper.Map<BookDto>(book);
        }

        public async Task<BookDto> GetProductByTitle(string Title)
        {
            Book book = await _dbContext.Books.Where(p => p.Title == Title).FirstOrDefaultAsync(); ;
            return _mapper.Map<BookDto>(book);
        }

        public async Task<IEnumerable<BookDto>> GetProducts()
        {
            List<Book> BookList = await _dbContext.Books.ToListAsync();
            return _mapper.Map<List<BookDto>>(BookList);
        }

        public async Task<BookDto> UpdateProduct(BookDto bookDto)
        {
            Book book = await _dbContext.Books.FindAsync(bookDto.Id);
            book.Title = bookDto.Title;
            book.Description = bookDto.Description; 
            book.Authorid = bookDto.Authorid;
            
            book.ISBN=bookDto.ISBN;
            book.InStock=bookDto.InStock;
            book.Price=bookDto.Price;
            book.ListCategories = bookDto.ListCategories;
            book.ImageURL = bookDto.ImageURL;
            await _dbContext.SaveChangesAsync();
            return _mapper.Map<BookDto>(book);






        }
    }

}
