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
    }
}
