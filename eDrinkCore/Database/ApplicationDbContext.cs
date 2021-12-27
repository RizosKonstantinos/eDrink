using eDrinkCore.Models;
using Microsoft.EntityFrameworkCore;

namespace eDrinkCore.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<BasketDrink> BasketDrinks { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-UIO6ESD\\SQLSERVER2019;Initial Catalog=eDrinkDb;Integrated Security=True");           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Basket - Drink many to many relationship (via BasketDrinks as intermediate table)
            modelBuilder.Entity<BasketDrink>().HasKey(d => new { d.BasketId, d.DrinkId });

            modelBuilder.Entity<BasketDrink>()
                .HasOne(b => b.Basket)
                .WithMany(d => d.BasketDrinks)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<BasketDrink>()
                .HasOne(d => d.Drink)
                .WithMany(d => d.BasketDrinks)
                .OnDelete(DeleteBehavior.NoAction);

            // Order - User one to many relationship
            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.Orders);

            // Basket - User one to many relationship
            modelBuilder.Entity<User>()
                .HasMany(u => u.Baskets)
                .WithOne(b=>b.User);

            // Basket - Order one to one relationship
            modelBuilder.Entity<Basket>()
                .HasOne(b => b.Order)
                .WithOne(o => o.Basket)
                .OnDelete(DeleteBehavior.NoAction);

            // Drink - Category one to many relationship
            modelBuilder.Entity<Drink>()
                .HasOne(d => d.Category)
                .WithMany(c => c.Drinks);
        }
    }
}
