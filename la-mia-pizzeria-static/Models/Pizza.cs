using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_static.Models
{
    [Table("Pizza")]
    
    [Index(nameof(Name), IsUnique = true)]
    public class Pizza
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string? Description { get; set; }

        public string? Image { get; set; }

        public decimal Price { get; set; }

        public Pizza() { }

        public Pizza(string name, string description, string image, decimal price)
        {
            Name = name;
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
