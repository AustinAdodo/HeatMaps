using Microsoft.AspNetCore.Mvc;

namespace HeatMaps.Controllers
{
    public class ProductsController : Controller
    {
        public readonly ILogger _logger;
        public readonly ApplicationDbContext _ProductsContext;

        public ProductsController(ILogger logger, ApplicationDbContext productsContext)
        {
            _logger = logger;
            _ProductsContext = productsContext;
        }

        [HttpGet(Name = "GetAllProducts")]
        public JsonResult Index()
        {
            var Products = new List<Product>();
            return Json(Products);
        }
    }
}
