namespace eDrinkCore.Models
{
    public class DrinkOrder
    {
        // Primary keys
        public int DrinkId { get; set; }
        public int OrderId { get; set; }

        // Navigation properties
        public Drink Drink { get; set; }
        public Order Order { get; set; }       
    }
}
