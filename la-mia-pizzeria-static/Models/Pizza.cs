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
        //Validazioni
        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [StringLength(30, ErrorMessage = "Il nome non può avere più di 30 caratteri")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [StringLength(300, ErrorMessage = "Il nome non può avere più di 300 caratteri")]
        public string Description { get; set; }

        public string? Image { get; set; }

        //[Required(ErrorMessage = "Il campo è obbligatorio")]
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }



        //relazione 1 : N con Category
        public int? CategoryId { get; set; }

        public Category? Category { get; set; }



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
