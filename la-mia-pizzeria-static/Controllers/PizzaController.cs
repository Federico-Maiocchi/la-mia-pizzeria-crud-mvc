using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> pizze = new List<Pizza>();

            pizze.Add(new Pizza
            {
                Nome = "Margherita",
                Description = "Pizza Margherita , normale",
                Image = "~/img/margherita.png",
                Price = 8.99m
            });
            pizze.Add(new Pizza
            {
                Nome = "Capricciosa",
                Description = "pizza capricciosa, molto capricciosa",
                Image = "~/img/capricciosa.png",
                Price = 9.99m
            });
            pizze.Add(new Pizza
            {
                Nome = "Quattro Stagioni",
                Description = "Pizza quattro stagioni, in primavera è buona",
                Image = "~/img/quattro-stagioni.png",
                Price = 10.99m
            });
            pizze.Add(new Pizza
            {
                Nome = "Diavola",
                Description = "Pizza diavola, è sempre arrabbiata",
                Image = "~/img/diavola.png",
                Price = 9.49m
            });
            pizze.Add(new Pizza
            {
                Nome = "Bufala",
                Description = "pizza bufala, è uno scherzo",
                Image = "~/img/bufala.png",
                Price = 11.49m
            });

            ViewData["Message"] = "Prova messaggio pizzacontroller";

            return View(pizze);
        }

        public IActionResult NewPath()
        {
            return View("Show")
        }
    }
}
