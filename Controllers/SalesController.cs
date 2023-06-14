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

        //GET all sales
        [HttpGet]
        public async Task<IActionResult> GetSales([FromQuery] int pageNumber = 1)
        {
            try
            {
                var sales = await _salesService.GetAll(pageNumber);
                return Json(sales);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving sales.");
                //return StatusCode(500, "Got in here but we have Internal server error, please try again later.");
                throw;
            }
        }

        //Get All Dates
        [HttpGet("dates")]
        public IActionResult GetDates()
        {
            return Json(_salesService.GetDates().Result);
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
        public IActionResult GetSalesOnthisDate(DateTime date)
        {
            var SalesforDate = _salesService.GetSalesOnDate(date);
            return Json(SalesforDate.Result);
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
