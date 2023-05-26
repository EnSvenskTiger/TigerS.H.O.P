using Microsoft.EntityFrameworkCore;
using TigerS.H.O.P.Models;

namespace TigerS.H.O.P.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; } = default!;
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "T-Shirt",
                    Description = "Cool T-Shirt",
                    Size = "XS-XXL",
                    Color = "Blue, White, Green, Red",
                    Price = 99,
                    ProductImage = "/lib/images/tiger1.jpg"


                },
                new Product
                {
                    Id = 2,
                    Title = "Hoodie",
                    Description = "Hoodie for everyone",
                    Size = "XS-XXL",
                    Color = "Blue, White, Green, Red",
                    Price = 299,
                    ProductImage = "/lib/images/tiger2.jpg"

                },
                new Product
                {
                    Id = 3,
                    Title = "Child",
                    Description = "Hoodie for everyone",
                    Size = "3-9 Year",
                    Color = "Blue, White, Green, Red",
                    Price = 179,
                    ProductImage = "/lib/images/tiger3.jpg"


                },
                new Product
                {
                    Id = 4,
                    Title = "Deluxe",
                    Description = "Hoodie for everyone",
                    Size = "XS-XXL",
                    Color = "Blue, White, Green, Red",
                    Price = 799,
                    ProductImage = "/lib/images/tiger4.jpg"

                }); 
        }
    }
}
