using Microsoft.AspNetCore.Mvc;

namespace HeatMaps.Controllers
{
    public class ProductsController : Controller
    {
        //public readonly ILogger<Product> _logger;
        public readonly ApplicationDbContext _ProductsContext;

        public ProductsController(ApplicationDbContext productsContext)
        {
            //_logger = logger;
            _ProductsContext = productsContext;
        }

        [HttpGet]
        [Route("api/products")]
        public IActionResult GetAll()
        {
            var Products = _ProductsContext.Products.ToList();
            if (Products != null) return Json(Products);
            var result = Enumerable.Empty<Product>();
            return Json(result);
        }


        [HttpGet("{id}")]
        [Route("api/products/:id")]
        public ActionResult<Product> GetAProduct(int id)
        {
            var Product = _ProductsContext.Products.Where(a => a.id == id).First();
            if (Product != null) return Json(Product);
            var result = Enumerable.Empty<Product>();
            return Json(result);
        }
    }
}
