using System;

namespace eDrinkCore.Models
{
    public class Order
    {
        // Primary and foreign keys
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BasketId { get; set; }

        // Base properties
        public decimal TotalCostPrice { get; set; }
        public DateTime OrderPlaced { get; set; } = DateTime.UtcNow;
        public OrderStatus OrderStatus { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        
        // Navigation property
        public User User { get; set; }
        public Basket Basket { get; set; }
    }
}
