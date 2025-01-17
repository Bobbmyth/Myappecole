using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class RedirectController : Controller
    {
        public IActionResult RedirectToAction()
        {
            return RedirectToAction("TargetAction");

        }

        public IActionResult RedirectToDifferentController()
        {
            return RedirectToAction("Index", "Home");
        }

        public IActionResult RedirectToExternalUrl()
        {
            return Redirect("https://www.google.com");
        }

        public IActionResult TargetAction()
        {
            return Content("Vous avez été redirigé vers cette action.");
        }
    }
}
