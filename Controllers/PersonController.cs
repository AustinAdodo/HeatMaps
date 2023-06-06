using Microsoft.AspNetCore.Mvc;

namespace HeatMaps.Controllers
{
    [ApiController]
    public class PersonController : Controller
    {
        public readonly ILogger _logger;
        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        //Check If API is up
        public IActionResult Index()
        {
            return StatusCode(200);
        }
    }
}
