using la_mia_pizzeria_static.Data;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public PizzaContext db = new PizzaContext();
        

        public IActionResult Index()
        {
            //List<Pizza> pizze = new List<Pizza>();
            //{
            //    new Pizza { Name = "Margherita", Description = "Pizza Margherita , normale", Image = "~/img/margherita.png", Price = 8.99m },
            //    new Pizza { Name = "Capricciosa", Description = "pizza capricciosa, molto capricciosa", Image = "~/img/capricciosa.png", Price = 9.99m },
            //    new Pizza { Name = "Quattro Stagioni", Description = "Pizza quattro stagioni, in primavera è buona", Image = "~/img/quattro-stagioni.png", Price = 10.99m },
            //    new Pizza { Name = "Diavola", Description = "Pizza diavola, è sempre arrabbiata", Image = "~/img/diavola.png", Price = 9.49m },
            //    new Pizza { Name = "Bufala", Description = "pizza bufala, è uno scherzo", Image = "~/img/bufala.png", Price = 11.49m }
            //};

            //db.Pizze.AddRange(pizze);
            //db.SaveChanges();

            //ViewData["Message"] = "Prova messaggio pizzacontroller";

            //return View(pizze);

            //List<Pizza> pizze = db.Pizze.ToList();

            //return View(pizze);

            return View(PizzaManager.GetAllPizzas());
        }

        
        public IActionResult Show(int id)
        {
            //var pizza = db.Pizze.Find(id);

            //if (pizza == null)
            //{
            //    return NotFound();
            //}

            //return View(pizza);

            var pizza = PizzaManager.GetPizzaById(id);
            if (pizza != null)
            {
                return View(pizza);
            } 
            else
            {
                return NotFound();
            } 
        }


        //Sezione CREATE
        //GET
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pizza data)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", data);
            }

            using (PizzaContext db = new PizzaContext())
            {
                var pizzaToCreate = new Pizza(data.Name, data.Description, data.Image, data.Price);

                db.Pizze.Add(pizzaToCreate);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }
    }
}
