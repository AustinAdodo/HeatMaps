using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HeatMaps.Controllers
{
    public class SalesController : Controller
    {
        public readonly ILogger _logger;
        public SalesController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        //Check If API is up
        public IActionResult Index()
        {
            return StatusCode(200);
        }

        //return all sales
        [HttpGet]
        public IActionResult GetAllSales()
        {
            return StatusCode(200);
        }

        [HttpGet]
        public IActionResult GetSpecificProductSale(string Saleid)
        {
            return StatusCode(200);
        }

        [HttpGet]
        public IActionResult GetSpecificProductSale(DateTime date)
        {
            return StatusCode(200);
        }

        //Add Sale
        [HttpPost]
        public IActionResult AddSale([FromBody] List<Product> Products, CancellationToken token)
        {
            Guid SaleId = Guid.NewGuid();
            Dictionary<Guid,List < Product>> Result = new Dictionary<Guid,List<Product>>();
            Result[SaleId] = Products;  
            return Ok(Result);
        }

        //Delete Sale
        [HttpPost]
        public IActionResult DeleteSale(Guid SaleId, CancellationToken token)
        {
            return Ok(200);
        }

        //Edit Sale

        [HttpPut]
        public IActionResult EditSale(Guid SaleId, CancellationToken token)
        {
            return Ok(200);
        }
    }
}
