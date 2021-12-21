using eDrinkCore.Models;
using Microsoft.EntityFrameworkCore;

namespace eDrinkCore.Database
{
    class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<DrinkOrder> DrinkOrders { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-UIO6ESD\\SQLSERVER2019;Initial Catalog=eDrinkDb;Integrated Security=True");           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Order - Drink many to many relationship (via DrinkOrder as intermediate table)
            modelBuilder.Entity<DrinkOrder>().HasKey(d => new { d.DrinkId, d.OrderId });

            modelBuilder.Entity<DrinkOrder>()
                .HasOne(d => d.Drink)
                .WithMany(o => o.DrinkOrders)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<DrinkOrder>()
                .HasOne(d => d.Order)
                .WithMany(d => d.DrinkOrders)
                .OnDelete(DeleteBehavior.NoAction);

            // Order - User one to many relationship
            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.Orders);

            // Drink - Category one to many relationship
            modelBuilder.Entity<Drink>()
                .HasOne(d => d.Category)
                .WithMany(c => c.Drinks);
        }
    }
}
