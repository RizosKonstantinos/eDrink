namespace eDrinkCore.Models
{
    public class BasketDrink
    {
        // Primary keys
        public int BasketId { get; set; }
        public int DrinkId { get; set; }

        // Base property
        public int DrinkAmount { get; set; }

        // Navigation properties
        public Basket Basket{ get; set; }
        public Drink Drink { get; set; }
    }
}
