using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HeatMaps.Controllers
{
    public class SalesController : Controller
    {
        public readonly ILogger _logger;
        public readonly ApplicationDbContext _SalesContext;
    
        public SalesController(ILogger<PersonController> logger, ApplicationDbContext salesContext)
        {
            _logger = logger;
            _SalesContext = salesContext;
        }

        //Check If API is up
        public IActionResult Index()
        {
            return StatusCode(200);
        }

        //return all sales
        [HttpGet]
        [Route(Preferences.Route5)]
        public IActionResult GetAllSales()
        {
            if (_SalesContext != null)  return StatusCode(200);
            var result = Enumerable.Empty<Sale>();
            return NotFound(result);
        }

        //Get sale(id)
        [HttpGet]
        [Route(Preferences.Route7)]
        public IActionResult GetSpecificProductSale(string Saleid)
        {
            return StatusCode(200);
        }

        //Get sale(date)
        [HttpGet]
        [Route(Preferences.Route6)]
        public IActionResult GetSpecificProductSale(DateTime date)
        {
            return StatusCode(200);
        }

        //Add Sale
        [HttpPost]
        [Route(Preferences.Route4)]
        public IActionResult AddSale([FromBody] List<Product> Products, CancellationToken token)
        {
            Guid SaleId = Guid.NewGuid();
            Dictionary<Guid, List<Product>> Result = new Dictionary<Guid, List<Product>>();
            Result[SaleId] = Products;
            return Ok(Result);
        }

        //Delete Sale
        [HttpPost]
        [Route(Preferences.Route3)]
        public IActionResult DeleteSale(Guid SaleId, CancellationToken token)
        {
            return Ok(200);
        }

        //Update Sale
        [HttpPut]
        [Route(Preferences.Route2)]
        public IActionResult EditSale(Guid SaleId, CancellationToken token)
        {
            return Ok(200);
        }
    }
}
