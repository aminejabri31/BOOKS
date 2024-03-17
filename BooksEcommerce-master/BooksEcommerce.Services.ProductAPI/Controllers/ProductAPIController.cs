using BooksEcommerce.Services.ProductAPI.Models.Dto;
using BooksEcommerce.Services.ProductAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace BooksEcommerce.Services.ProductAPI.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductAPIController : ControllerBase
    {
        protected ReponseDto _reponse;
        private readonly IBookRepository _bookRepository;
        private readonly IAuthorRepository _authorRepository;
        private readonly ICategoryRepository _categoryRepository;
        public ProductAPIController(IBookRepository bookRepository, IAuthorRepository authorRepository, ICategoryRepository categoryRepository)
        {
            this._reponse = new ReponseDto();
            _bookRepository = bookRepository;
            _authorRepository = authorRepository;
            _categoryRepository = categoryRepository;
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<object> GetAllBooks()
        {//try
            {
                IEnumerable<BookDto> bookDto = await _bookRepository.GetProducts();
                _reponse.Result = bookDto;
                return _reponse;
            }
        }
        [HttpGet("/{id}")]
        [AllowAnonymous]
        public async Task<object> GetById(int id)
        {//try
            {
                BookDto bookDto = await _bookRepository.GetProductById(id);
                _reponse.Result = bookDto;
                return _reponse;

            }
        }
        [HttpGet("/category/{categoryDto}")]
        [AllowAnonymous]
        public async Task<object> GetBooksByCategory(List<CategoryDto> categoryDto)
        {//try
            {
                IEnumerable<BookDto> booksDto = await _categoryRepository.GetBooksByCategory(categoryDto);
                _reponse.Result = booksDto;
                return _reponse;

            }
        }
        [HttpGet("/titre/{title}")]
        [AllowAnonymous]
        public async Task<object> GetProductByTitle(string Title)
        {//try
            {
                BookDto bookDto = await _bookRepository.GetProductByTitle(Title);
                _reponse.Result = bookDto;
                return _reponse;

            }
        }
        [HttpGet("/author/{authorDto}")]
        [AllowAnonymous]
        public async Task<object> GetBooksByAuther(AuthorDto authorDto)
        {//try
            {
                IEnumerable<BookDto> booksDto = await _authorRepository.GetBooksByAuther(authorDto);
                _reponse.Result = booksDto;
                return _reponse;

            }
        }
        [HttpGet("/author/authorId/{authorId}")]
        [AllowAnonymous]
        public async Task<object> GetBooksByAuther(int id)
        {//try
            {
                AuthorDto author = await _authorRepository.GetAutherById(id);
                _reponse.Result = author;
                return _reponse;

            }
        }

        //create
        [HttpPost]
        public async Task<object> CreateProduct(BookDto book)
        {//try
            {
                BookDto bookDto = await _bookRepository.CreateProduct(book);
                _reponse.Result = bookDto;
                return _reponse;
            }
        }
        
        [HttpPost ("/category")]
        public async Task<object> CreateCategory(CategoryDto categoryDto)
        {//try
            {
                CategoryDto categoryDtos = await _categoryRepository.CreateCategory(categoryDto);
                _reponse.Result = categoryDtos;
                return _reponse;
            }
        }
        [HttpPost("/author")]
        public async Task<object> CreateAuthor(AuthorDto authorDto)
        {//try
            {
                AuthorDto authorDtos = await _authorRepository.CreateAuthor(authorDto);
                _reponse.Result = authorDtos;
                return _reponse;
            }
        }
        
        //delete
        [HttpDelete("/{id}")]
        public async Task<bool> DeletById(int id)
        {//try
            { return await _bookRepository.DeleteProduct(id); }

        }
        //update
        [HttpPut("/{id}")]
        public async Task<object> UpdateProduct(BookDto book)
        {//try
            {
                BookDto bookDto = await _bookRepository.UpdateProduct(book);
                _reponse.Result = bookDto;
                return _reponse;
            }
        }
        //show all authors
        [HttpGet("/author")]
        public async Task<object> GetAllAuther()
        {//try
            {
                IEnumerable<AuthorDto> author = await _authorRepository.GetAllAuther();
                _reponse.Result = author;
                return _reponse;
            }
        }
        [HttpGet("/author/{name}")]
        public async Task<object> GetAutherByName(string name )
        {//try
            {
                AuthorDto author = await _authorRepository.GetAutherByName(name);
                _reponse.Result = author;
                return _reponse;
            }
        }
        //show all category
        [HttpGet("/category")]
        public async Task<object> GetCategoryList()
        {//try
            {
                IEnumerable<CategoryDto> categoryDto = await _categoryRepository.GetCategoryList();
                _reponse.Result = categoryDto;
                return _reponse;
            }
        }
        [HttpGet("/category/{name}")]
        public async Task<object> GetCategoryByName(string name)
        {//try
            {
                CategoryDto categoryDto = await _categoryRepository.GetCategoryByName(name);
                _reponse.Result = categoryDto;
                return _reponse;
            }
        }


    }
}
