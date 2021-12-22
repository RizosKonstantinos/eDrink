using System.Collections.Generic;

namespace eDrinkCore.Models
{
    public class Basket
    {
        // Primary and foreign keys
        public int Id { get; set; }
        public int UserId { get; set; }

        // Base property
        public decimal TotalPrice{ get; set; }

        // Navigation properties
        public User User { get; set; }
        public Order Order { get; set; }
        public List<BasketDrink> BasketDrinks { get; set; }
    }
}
