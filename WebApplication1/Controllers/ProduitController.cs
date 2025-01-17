// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using System.Linq.Expressions;
// using WebApplication1.Models;

// namespace WebApplication1.Controllers
// {
//     public class ProduitController : Controller
//     {

//         private readonly Myctx _context;

//         public ProduitController(Myctx context)
//         {
//             _context = context;
//         }


//         public IActionResult Index()
//         {

//             return View(_context.Produits.ToList());

//         }

//         public IActionResult Details(int? id)
//         {
//             if ( id == null)
//             {
//                 return
//                     NotFound();
//             }
//             var produit = _context.Produits
//                 .FirstOrDefault(m => m.Id == id);
//             if ( produit == null)
//             {
//                 return
//                     NotFound();

//             }
//             return View(produit);
//         }


//         [HttpGet]
//         public IActionResult Create()
//         {
//             return View();
//         }



//         [HttpPost]
//         public IActionResult Create([Bind("Id,Name,Price")] Produit  produit)
//         {
//             if(ModelState.IsValid)
//             {
//                 _context.Add(produit);
//                 _context.SaveChanges();
//                 //return RedirectToAction(nameof(Create));
//             }
//             return View();
//         }

//         public IActionResult Edit(int id)
//         {
//             if (id == null)
//             {
//                 return
//                     NotFound();
//             }
//             var produit = _context.Produits.Find(id);
//             if (produit == null)
//             {
//                 return
//                     NotFound();
//             }
//             return View(produit);
//         }

//         [HttpPost]
//         [ValidateAntiForgeryToken]
//         public IActionResult Edit(int id, [Bind("Id,Name,Price")] Produit produits)
//         {
//             if (id != produits.Id)
//             {
//                 return
//                     NotFound();
//             }
//             if (ModelState.IsValid)
//             {
//                 try
//                 {
//                     _context.Update(produits);
//                     _context.SaveChanges();
//                 }
//                 catch (DbUpdateConcurrencyException)
//                 {
//                     if (!ProduitExists(produits.Id))
//                     {
//                         return
//                             NotFound();
//                     }
//                     else
//                     {
//                         throw;
//                     }
//                 }
//                 return RedirectToAction(nameof(Index));
//             }
//             return View(produits);
//         }



//                 public IActionResult Delete(int? id)
//                 {
//                     if (id == null)
//                     {
//                         return NotFound();
//                     }

//                     var produit = _context.Produits
//                         .FirstOrDefault(m => m.Id == id);
//                     if (produit == null)
//                     {
//                         return NotFound();
//                     }

//                     return View(produit);
//                 }
//         [HttpPost, ActionName("Delete")]
//         [ValidateAntiForgeryToken]
//         public IActionResult DeleteConfirmed(int id)
//         {
//             var produit = _context.Produits.Find(id);
//             if (produit != null)
//             {
//                 _context.Produits.Remove(produit);
//             }   

//             _context.SaveChanges();
//             return RedirectToAction(nameof(Index));
//         }
//         private bool ProduitExists(int id)
//         {
//             return _context.Produits.Any(e => e.Id == id);
//         }
//     }

// }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers

{
    public class ProduitsController : Controller
    {
        private readonly Myctx _context;

        public ProduitsController(Myctx context)
        {

            _context = context;
        }

        // GET: Produits
        public IActionResult Index()
        {
            return View(_context.Produits.ToList());
        }

        // GET: Produits/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produit = _context.Produits
                .FirstOrDefault(m => m.Id == id);
            if (produit == null)
            {
                return NotFound();
            }

            return View(produit);
        }

        // GET: Produits/Create

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Create([Bind("Id,Name,Price")] Produit produit)
        {
            if (ModelState.IsValid)
            {
                _context.Add(produit);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(produit);
        }

        // GET: Produits/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produit = _context.Produits.Find(id);
            if (produit == null)
            {
                return NotFound();
            }
            return View(produit);
        }

        // POST: Produits/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Name,Price")] Produit produit)
        {
            if (id != produit.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(produit);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProduitExists(produit.Id))
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
            return View(produit);
        }

        // GET: Produits/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produit = _context.Produits
                .FirstOrDefault(m => m.Id == id);
            if (produit == null)
            {
                return NotFound();
            }

            return View(produit);
        }

        // POST: Produits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var produit = _context.Produits.Find(id);
            if (produit != null)
            {
                _context.Produits.Remove(produit);
            }

            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool ProduitExists(int id)
        {
            return _context.Produits.Any(e => e.Id == id);
        }
    }
}
