using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AuthentificationController : Controller
    {
        
        public IActionResult Inscription()
        {
            return View();
        }

        public IActionResult Connexion()
        {
            return View();
        }
    }
}
