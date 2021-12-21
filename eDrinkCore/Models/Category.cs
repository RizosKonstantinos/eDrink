using System.Collections.Generic;

namespace eDrinkCore.Models
{
    public class Category
    {
        // Primary key
        public int Id { get; set; }

        // Base properties
        public string Name { get; set; }
        public string Description { get; set; }

        // Navigation property
        public List<Drink> Drinks { get; set; }
    }
}
