using Microsoft.AspNetCore.Mvc.Rendering;

namespace la_mia_pizzeria_static.Models
{
    public class PizzaFormModel
    {
        //Pizza
        public Pizza Pizza {  get; set; }
        //Categorie
        public List<Category>? Categories {  get; set; }
        //Ingredienti
        //elecon ingredienti selezionabili
        public List<SelectListItem>? Ingradients { get; set; }
        //elecon degli ID degli ingredienti selezionati
        public List<string>? SelectedIngredients { get; set; }



        public PizzaFormModel() { }

        public PizzaFormModel(Pizza pizza, List<Category>? categories)
        {
            Pizza = pizza;
            Categories = categories;
        }
    }
}
