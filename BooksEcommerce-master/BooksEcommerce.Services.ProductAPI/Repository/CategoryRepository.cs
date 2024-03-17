using AutoMapper;
using BooksEcommerce.Services.ProductAPI.DBContext;
using BooksEcommerce.Services.ProductAPI.Models;
using BooksEcommerce.Services.ProductAPI.Models.Dto;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace BooksEcommerce.Services.ProductAPI.Repository
{
    public  class CategoryRepository : ICategoryRepository
    {
        private readonly BookDBContext _dbContext;
        private IMapper _mapper;
        public CategoryRepository(BookDBContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<CategoryDto> CreateCategory(CategoryDto categoryDto)
        {
            Category category = new Category { Name = categoryDto.Name };
            await _dbContext.Categories.AddAsync(category);
            await _dbContext.SaveChangesAsync();
            return _mapper.Map<CategoryDto>(category); 
        }

        public async Task<IEnumerable<BookDto>> GetBooksByCategory(List<CategoryDto> categoryDtos)
        {
            List<string> categoryNames = categoryDtos.Select(c => c.Name).ToList();
            List<Book> books = new List<Book>();

            if (categoryNames.Count == 0)
            {
                books = await _dbContext.Books.ToListAsync();
            }
            else
            {
                foreach (string category in categoryNames)
                {
                    books.AddRange(await _dbContext.Books.Where(a => a.ListCategories.Contains(category)).ToListAsync());
                }
            }

            return _mapper.Map<List<BookDto>>(books);
        }



        public async Task<CategoryDto> GetCategoryByName(string name)
        {
            Category category = await _dbContext.Categories.FirstOrDefaultAsync(a => a.Name == name);
               return  _mapper.Map<CategoryDto>(category);
        }
        public async Task<CategoryDto> GetCategoryById(int id)
        {
            Category category = await _dbContext.Categories.FirstOrDefaultAsync(a => a.Id == id);
            return _mapper.Map<CategoryDto>(category);
        }

        public async Task<IEnumerable<CategoryDto>> GetCategoryList()
        {
            List<Category> CategoryList = await _dbContext.Categories.ToListAsync();
            return _mapper.Map<List<CategoryDto>>(CategoryList);
        }
    }
}
