namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public string Nome { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public decimal Price { get; set; }

        public Pizza() { }

        public Pizza(string nome, string description, string image, decimal price)
        {
            Nome = nome;
            Description = description;
            Image = image;
            Price = price;
        }

        /*public string PriceString()
        {
            string priceStringConvert = $"{Price} €";

            return priceStringConvert;
        }*/
    }
}
