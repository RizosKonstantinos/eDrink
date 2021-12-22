using System.Collections.Generic;

namespace eDrinkCore.Models
{
    public class User
    {
        // Primary key
        public int Id { get; set; }

        // Base properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Navigation property
        public List<Basket> Baskets { get; set; }
        public List<Order> Orders { get; set; }
    }
}
