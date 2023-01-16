using LaMiaPizzeria.Database;
using LaMiaPizzeria.Models;
using Microsoft.AspNetCore.Mvc;

namespace LaMiaPizzeria.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            using (PizzaContext db = new PizzaContext())
            {
                List<Pizza> pizze = db.Pizze.ToList<Pizza>();
                return View("Index", pizze);
            }
            
        }

        [HttpGet]
        public IActionResult AggiungiPizza()
        {
            return View("AggiungiPizza");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AggiungiPizzaTramiteForm(Pizza DatiNelForm)
        {
            if (!ModelState.IsValid)
            {
                return View("AggiungiPizza", DatiNelForm);
            }

            using (PizzaContext db= new PizzaContext())
            {
                db.Pizze.Add(DatiNelForm);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
