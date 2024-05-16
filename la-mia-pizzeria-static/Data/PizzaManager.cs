using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Identity;

namespace la_mia_pizzeria_static.Data
{
    public static class PizzaManager
    {
        public static int CountAllPizzas()
        {
            using PizzaContext db = new PizzaContext();
            return db.Pizze.Count();

        }
        public static List<Pizza> GetAllPizzas()
        {
            using PizzaContext db = new PizzaContext();
            return db.Pizze.ToList();
        }

        public static Pizza GetPizzaById(int id)
        {
            using PizzaContext db = new PizzaContext();
            return db.Pizze.FirstOrDefault(p => p.Id == id);
        }

        public static void InserPizza(Pizza pizza)
        {
            using PizzaContext db = new PizzaContext();
            db.Pizze.Add(pizza);
            db.SaveChanges();
        }

        public static void Seed()
        {
            using PizzaContext db = new PizzaContext();

            List<Pizza> pizze = new List<Pizza>()
            {
                new Pizza { Name = "Margherita", Description = "Pizza Margherita , normale", Image = "~/img/margherita.png", Price = 8.99m },
                new Pizza { Name = "Capricciosa", Description = "pizza capricciosa, molto capricciosa", Image = "~/img/capricciosa.png", Price = 9.99m },
                new Pizza { Name = "Quattro Stagioni", Description = "Pizza quattro stagioni, in primavera è buona", Image = "~/img/quattro-stagioni.png", Price = 10.99m },
                new Pizza { Name = "Diavola", Description = "Pizza diavola, è sempre arrabbiata", Image = "~/img/diavola.png", Price = 9.49m },
                new Pizza { Name = "Bufala", Description = "pizza bufala, è uno scherzo", Image = "~/img/bufala.png", Price = 11.49m },
            };

            db.Pizze.AddRange(pizze);
            db.SaveChanges();
        }
    }
}
