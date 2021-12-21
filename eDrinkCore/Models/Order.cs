using System;
using System.Collections.Generic;

namespace eDrinkCore.Models
{
    public class Order
    {
        // Primary and foreign keys
        public int Id { get; set; }
        public int UserId { get; set; }

        // Base properties
        public decimal OrderTotalAmount { get; set; }
        public DateTime OrderPlaced { get; set; } = DateTime.UtcNow;
        
        // Navigation property
        public User User { get; set; }
        public List<DrinkOrder> DrinkOrders { get; set; }
    }
}
