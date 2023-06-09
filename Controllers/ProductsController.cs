using HeatMaps.Utilities.Products;
using Microsoft.AspNetCore.Mvc;

namespace HeatMaps.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        //public readonly ILogger<Product> _logger;
        public readonly IProductService _ProductsService;

        public ProductsController(IProductService productsService)
        {
            //_logger = logger;
            _ProductsService = productsService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _ProductsService.GetAll();
            return Json(products);
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetAProduct(int id)
        {
            var product = _ProductsService.Get(id);
            return Json(product);
        }

        //[HttpGet("{ProductId}")]
        //public ActionResult<Product> GetAProduct(string ProductId)
        //{
        //    var product = _ProductsService.Get(ProductId);
        //    return Json(product);
        //}
    }
}
