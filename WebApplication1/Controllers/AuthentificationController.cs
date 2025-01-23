using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AuthentificationController : Controller
    {
        private readonly Myctx _context;

        public AuthentificationController(Myctx context)
        {
            _context = context;
        }

        // GET: Inscription
        public IActionResult Inscription()
        {
            return View();
        }

        // POST: Inscription
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Inscription([Bind("Name,Prenom,Email,Password")] Client client)
        {
            if (ModelState.IsValid)
            {
                _context.Add(client); 
                _context.SaveChanges(); 
                return RedirectToAction("Connexion"); 
            }
            return View(client); 
        }

        // GET: Clients/Index
        public IActionResult Index()
        {
            var clients = _context.Clients.ToList(); // Récupère tous les clients de la base de données
            return View(clients); // Envoie les données à la vue Index.cshtml
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = _context.Clients.FirstOrDefault(m => m.Id == id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = _context.Clients.Find(id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Name,Prenom,Email,Password")] Client client)
        {
            if (id != client.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(client);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Clients.Any(e => e.Id == client.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(Index));
            }

            return View(client);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = _context.Clients.FirstOrDefault(m => m.Id == id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }


        [HttpPost, ActionName("DeleteConfirmed")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var client = _context.Clients.Find(id);
            if (client != null)
            {
                _context.Clients.Remove(client);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }




        // GET: Connexion
        public IActionResult Connexion()
        {
            return View();
        }

        // POST: Connexion (validation des informations de connexion)
        [HttpPost]
        public IActionResult Connexion(string email, string password)
        {
            var client = _context.Clients.FirstOrDefault(c => c.Email == email && c.Password == password);

            if (client != null)
            {
                
                return RedirectToAction("Index", "Home");
            }

            
            ViewBag.ErrorMessage = "Email ou mot de passe incorrect.";
            return View();
        }
    }
}
