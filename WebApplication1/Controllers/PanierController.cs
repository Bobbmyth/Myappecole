using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class PanierController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
