using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class CatalogueController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
