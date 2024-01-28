using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System;

namespace sampleDotNet8Shop.ShopUI.Models
{
    public class ShopDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ShopDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Category = "Mobile",
                    Name = "Apple IPhone 14 ProMax",
                    Description = "This is a IOS Phone And Create By Apple",
                    Price = 70_000_000
                },
                new Product
                {
                    Id = 2,
                    Category = "Mobile",
                    Name = "Sumsung Galexy S24 ultra",
                    Description = "This is a Android Phone And Create By Sumsung",
                    Price = 45_000_000
                },
                new Product
                {
                    Id = 3,
                    Category = "Mobile",
                    Name = "Xiaomi ME14 Ultra",
                    Description = "This is a Android Phone And Create By Xiaomi",
                    Price = 40_000_000
                },
                new Product
                {
                    Id = 4,
                    Category = "Mobile",
                    Name = "Realme C13 Ultra",
                    Description = "This is a Android Phone And Create By Realme",
                    Price = 30_000_000
                },
                new Product
                {
                    Id = 5,
                    Category = "Laptop",
                    Name = "Asus Zenbook 13 OLED",
                    Description = "The AMD-equipped Asus Zenbook 13 OLED is currently our top recommendation for a great budget laptop",
                    Price = 35_000_000
                },
                new Product
                {
                    Id = 6,
                    Category = "Laptop",
                    Name = " Dell XPS 15 OLED",
                    Description = "The Dell XPS 15 is our current pick for best Windows laptop overall",
                    Price = 40_000_000
                },
                new Product
                {
                    Id = 7,
                    Category = "Laptop",
                    Name = "Macbook Air M2",
                    Description = "The MacBook Air M2 is the best laptop for the money",
                    Price = 50_000_000
                },
                new Product
                {
                    Id = 8,
                    Category = "PC",
                    Name = "Apple iMac M3(2024)",
                    Description = "The 24-inch iMac is especially well-suited as a family computer or if you want something other than a laptop to easily move from room to room",
                    Price = 20_000_000
                },
                new Product
                {
                    Id = 9,
                    Category = "PC",
                    Name = "Dell XPS 8960 Desktop",
                    Description = "While we like all-in-ones for their convenience, they're not easy to upgrade (if they can be at all)",
                    Price = 16_000_000
                },
                new Product
                {
                    Id = 10,
                    Category = "PC",
                    Name = "Origin PC 5000T",
                    Description = "If you're dissatisfied with the lack of configuration options available for prebuilt gaming desktops",
                    Price = 12_000_000
                }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
