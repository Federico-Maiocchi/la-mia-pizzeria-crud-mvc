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
           
            //PizzaManager.Seed();

            return View(PizzaManager.GetAllPizzas());
        }

        
        public IActionResult Show(int id)
        {
         
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


        //sezione UPDATE
        //GET
        [HttpGet]
        public IActionResult Update(int id)
        {
            
            Pizza pizzaToEdit = PizzaManager.GetPizzaById(id);

            if (pizzaToEdit == null)
            {
                return NotFound();
            }
            else
            {
                return View(pizzaToEdit);
            }
              
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int id, Pizza data)
        {
            if (!ModelState.IsValid)
            {
                return View("Update");
            }

            //using (PizzaContext db = new PizzaContext())
            //{
            //    Pizza pizzaToEdit = PizzaManager.GetPizzaById(id);

            //    if (pizzaToEdit != null)
            //    {
            //        pizzaToEdit.Name = data.Name;
            //        pizzaToEdit.Description = data.Description;
            //        pizzaToEdit.Image = data.Image;
            //        pizzaToEdit.Price = data.Price;

            //        db.SaveChanges();

            //        return RedirectToAction("Index");
            //    }
            //    else
            //    {
            //        return NotFound();
            //    }
            //}

            if (PizzaManager.UpdatePizza(id, data.Name, data.Description, data.Image, data.Price))
            {
                return RedirectToAction("Index");
            }
            else
            {
                return NotFound();
            }   
        }
    }
}
