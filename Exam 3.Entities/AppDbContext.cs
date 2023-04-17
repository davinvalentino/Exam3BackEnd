using Microsoft.AspNetCore.DataProtection.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_3.Entities
{
    public class AppDbContext : DbContext, IDataProtectionKeyContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var user1 = new User
            {
                Id = "U001",
                Name = "Aldi Liam",
                Email = "aldi@gmail.com",
                Password = "aldi123",
                CreatedAt = DateTimeOffset.UtcNow,
            };
            var user2 = new User
            {
                Id = "U002",
                Name = "Hans Jumanto",
                Email = "hans@gmail.com",
                Password = "hans123",
                CreatedAt = DateTimeOffset.UtcNow,
            };
            var restaurant1 = new Restaurant
            {
                Id = "R001",
                Name = "Payakumbuah",
                CreatedAt = DateTimeOffset.UtcNow,
            };
            var restaurant2 = new Restaurant
            {
                Id = "R002",
                Name = "Warung Satria",
                CreatedAt = DateTimeOffset.UtcNow,
            };
            var food1 = new FoodItem
            {
                Id = "F001",
                Name = "Rendang",
                Price = 15000,
                RestaurantId = restaurant1.Id,
                CreatedAt = DateTimeOffset.UtcNow,
            };
            var food2 = new FoodItem
            {
                Id = "F002",
                Name = "Dendeng Batokok",
                Price = 18000,
                RestaurantId = restaurant1.Id,
                CreatedAt = DateTimeOffset.UtcNow,
            };
            var food3 = new FoodItem
            {
                Id = "F003",
                Name = "Telor Dadar",
                Price = 8000,
                RestaurantId = restaurant2.Id,
                CreatedAt = DateTimeOffset.UtcNow,
            };
            var food4 = new FoodItem
            {
                Id = "F004",
                Name = "Cah Kangkung",
                Price = 6000,
                RestaurantId = restaurant2.Id,
                CreatedAt = DateTimeOffset.UtcNow,
            };
            var drink1 = new FoodItem
            {
                Id = "D001",
                Name = "Es Timun Serut",
                Price = 10000,
                RestaurantId = restaurant1.Id,
                CreatedAt = DateTimeOffset.UtcNow,
            };
            var drink2 = new FoodItem
            {
                Id = "D002",
                Name = "Jus Tomat",
                Price = 10000,
                RestaurantId = restaurant1.Id,
                CreatedAt = DateTimeOffset.UtcNow,
            };
            var drink3 = new FoodItem
            {
                Id = "D003",
                Name = "Es Teh Tawar",
                Price = 3000,
                RestaurantId = restaurant2.Id,
                CreatedAt = DateTimeOffset.UtcNow,
            };
            var drink4 = new FoodItem
            {
                Id = "D004",
                Name = "Es Jeruk",
                Price = 6000,
                RestaurantId = restaurant2.Id,
                CreatedAt = DateTimeOffset.UtcNow,
            };


            modelBuilder.Entity<User>().HasData(user1, user2);
            modelBuilder.Entity<Restaurant>().HasData(restaurant1, restaurant2);
            modelBuilder.Entity<FoodItem>().HasData(food1, food2, food3, food4, drink1, drink2, drink3, drink4);
        }
        public DbSet<User> Users => Set<User>();
        public DbSet<Cart> Carts => Set<Cart>();
        public DbSet<CartDetail> CartDetails => Set<CartDetail>();
        public DbSet<Restaurant> Restaurants => Set<Restaurant>();
        public DbSet<FoodItem> FoodItems => Set<FoodItem>();

        public DbSet<DataProtectionKey> DataProtectionKeys => Set<DataProtectionKey>();
    }
}
