using BookEcommerce.Web.Models;
using BookEcommerce.Web.Service.IService;
using BooksEcommerce.Web;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BookEcommerce.Web.Controllers
{
    public class BookController : Controller
    {
        private readonly IProductService _productService;
        public BookController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> BookIndex()
        {
            List<BookDto> List = new();
            var reponse = await _productService.GetAllBooks<ReponseDto>(); 
            if (reponse != null && reponse.IsSuccess)
                List = JsonConvert.DeserializeObject<List<BookDto>>(Convert.ToString(reponse.Result));
            return View(List);
        }
        public async Task<IActionResult>  ProductCreate()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ProductCreate(BookDto model)
        {
            var reponse = await _productService.CreateProductAsync<ReponseDto>(model);
            if (reponse != null && reponse.IsSuccess)
            {
                return RedirectToAction(nameof(BookIndex));
            }
            return View(model);
        }
        [HttpGet]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GetAutherByNameAsync(string i)
        {
            var reponse = await _productService.GetAutherByNameAsync<ReponseDto>(i);
            if (reponse != null && reponse.IsSuccess)
            {
                return RedirectToAction(nameof(ProductCreate));
            }
            return View(i);
        }

    }
}
