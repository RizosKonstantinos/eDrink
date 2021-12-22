using System.Collections.Generic;
namespace eDrinkCore.Models
{
    public class Drink
    {
        // Primary and foreign keys
        public int Id { get; set; }
        public int CategoryId { get; set; }

        // Base properties
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsPreferredDrink { get; set; }
        public bool InStock { get; set; }
        
        // Navigation property
        public virtual Category Category { get; set; }
        public List<BasketDrink> BasketDrinks { get; set; }
    }
}
