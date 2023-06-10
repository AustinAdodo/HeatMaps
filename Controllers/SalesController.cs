using HeatMaps.Utilities.Sales;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HeatMaps.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SalesController : Controller
    {
        public readonly ILogger _logger;
        public readonly ISalesService _salesService;

        public SalesController(ILogger<PersonController> logger, ISalesService salesService)
        {
            _logger = logger;
            _salesService = salesService;
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
            return Json(_salesService.GetAll().Result);
        }

        //Get sale(id)
        [HttpGet("{id:int}")]
        public IActionResult GetSpecificProductSale(int id)
        {
            var result = _salesService.Get(id);
            return Json(result.Result);
        }

        //Get sale(id)
        [HttpGet]
        [Route(Preferences.Route7)]
        public IActionResult GetSpecificProductSale(string Saleid)
        {
            var result = _salesService.Get(Saleid);
            return Json(result.Result);
        }

        //Get sale(date)
        [HttpGet]
        [Route(Preferences.Route6)]
        public IActionResult GetSalesOnthisDate(string date)
        {
            var SalesforDate = _salesService.GetAll().Result.Where(a=>a.Date == DateTime.Parse(date));
            return Json(SalesforDate);
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
        public IActionResult Update(Guid SaleId, CancellationToken token)
        {
            return Ok(200);
        }
    }
}
