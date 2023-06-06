using Microsoft.AspNetCore.Mvc;

namespace HeatMaps.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
