using AutoMapper;
using BooksEcommerce.Services.ProductAPI.DBContext;
using BooksEcommerce.Services.ProductAPI.Models;
using BooksEcommerce.Services.ProductAPI.Models.Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace BooksEcommerce.Services.ProductAPI.Repository
{
    public class AuthorRepository :IAuthorRepository
    {
        private readonly BookDBContext _dbContext;
        private IMapper _mapper;
        public AuthorRepository(BookDBContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<AuthorDto> CreateAuthor(AuthorDto authorDto)
        {
            Author author = new Author
            {
                FullName = authorDto.FullName,
                ListBookTitels = authorDto.ListBookTitels,

                
            };
            await _dbContext.Authors.AddAsync(author);
            await _dbContext.SaveChangesAsync();
            return _mapper.Map<AuthorDto>(author);
        }

        public async Task<IEnumerable<AuthorDto>> GetAllAuther()
        {
            List<Author> AuthorList = await _dbContext.Authors.ToListAsync();
            return _mapper.Map<List<AuthorDto>>(AuthorList);
        }

        public async Task<AuthorDto> GetAutherByName(string name)
        {
            Author author = await _dbContext.Authors.FirstOrDefaultAsync(a => a.FullName.ToLower() == name.ToLower());
            return _mapper.Map<AuthorDto>(author);
        }
        public async Task<AuthorDto> GetAutherById(int id)
        {
            Author author = await _dbContext.Authors.FirstAsync(a => a.Id == id);
            return _mapper.Map<AuthorDto>(author);
        }

        public async Task<IEnumerable<BookDto>> GetBooksByAuther(AuthorDto authorDto)
        {
            int id = authorDto.Id;
            var books = await _dbContext.Books.Where(a => a.Authorid == id).ToListAsync();
            return _mapper.Map<List<BookDto>>(books);
        }



    }
}
