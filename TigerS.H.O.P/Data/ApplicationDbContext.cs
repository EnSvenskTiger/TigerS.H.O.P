using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TigerS.H.O.P.Models;

namespace TigerS.H.O.P.Data
{
    public class ApplicationDbContext : IdentityDbContext
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
            base.OnModelCreating(modelBuilder);

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
                    Description = "Clothes for the little ones",
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

                },
                new Product
                {
                    Id = 5,
                    Title = "T-Shirt",
                    Description = "Fantastic t-shirt for everyone",
                    Size = "XS-XXL",
                    Color = "Blue, White, Green, Red, Yellow",
                    Price = 399,
                    ProductImage = "/lib/images/tiger5.jpg"

                },
                new Product
                {
                    Id = 6,
                    Title = "Children's costume",
                    Description = "Costume för children",
                    Size = "3-8 year",
                    Color = "Tiger",
                    Price = 799,
                    ProductImage = "/lib/images/tiger6.jpg"

                },
                new Product
                {
                    Id = 7,
                    Title = "Suit jacket",
                    Description = "Nice, super nice",
                    Size = "XS-XXXL",
                    Color = "Tiger",
                    Price = 2999,
                    ProductImage = "/lib/images/tiger7.jpg"

                },
                new Product
                {
                    Id = 8,
                    Title = "Tiger Style",
                    Description = "Dress for everyday use",
                    Size = "XS-XXXL",
                    Color = "Tiger",
                    Price = 1499,
                    ProductImage = "/lib/images/tiger8.jpg"

                },
                new Product
                {
                    Id = 9,
                    Title = "Dress",
                    Description = "Dress for everyday use",
                    Size = "XS-XXXL",
                    Color = "Tiger",
                    Price = 7999,
                    ProductImage = "/lib/images/tiger9.jpg"

                },
                new Product
                {
                    Id = 10,
                    Title = "Shirt",
                    Description = "Lovely shirt",
                    Size = "XS-XXXL",
                    Color = "Red, Blue",
                    Price = 299,
                    ProductImage = "/lib/images/tiger10.jpg"

                },
                new Product
                {
                    Id = 11,
                    Title = "Long sleeved",
                    Description = "Super cool long sleeved tiger motive",
                    Size = "XS-XXXL",
                    Color = "Tiger",
                    Price = 349,
                    ProductImage = "/lib/images/tiger11.jpg"

                },
                new Product
                {
                    Id = 12,
                    Title = "Dress",
                    Description = "Dress for special partys",
                    Size = "XS-XXXL",
                    Color = "Black, White",
                    Price = 999,
                    ProductImage = "/lib/images/tiger12.jpg"

                });




        }
    }
}
