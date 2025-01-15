using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class PitieController1 : Controller
    {
        public IActionResult Pitie()
        {

            ViewBag.Email = 



            ViewBag.message = "bonjour cs";

            return View();
        }
    }
}
