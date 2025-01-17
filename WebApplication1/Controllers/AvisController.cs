using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class AvisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
