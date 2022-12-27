using Microsoft.EntityFrameworkCore;
using ReviewSite_WebAPI.Models;

namespace ReviewSite_WebAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    Name = "White T-Shirt",
                    Description = "Lorem ipsum dolor sit amet.",
                    ImageUrl = "./Images/white_t-shirt.jpg",
                    CreatedDate = DateTime.Now 
                },
                new Product()
                {
                    Id = 2,
                    Name = "Black T-Shirt",
                    Description = "Lorem ipsum dolor sit amet.",
                    ImageUrl = "./Images/black_t-shirt.jpg",
                    CreatedDate = DateTime.Now
                },
                new Product()
                {
                    Id = 3,
                    Name = "Red T-Shirt",
                    Description = "Lorem ipsum dolor sit amet.",
                    ImageUrl = "./Images/red_t-shirt.jpg",
                    CreatedDate = DateTime.Now
                },
                new Product()
                {
                    Id = 4,
                    Name = "Blue T-Shirt",
                    Description = "Lorem ipsum dolor sit amet.",
                    ImageUrl = "./Images/blue_t-shirt.jpg",
                    CreatedDate = DateTime.Now
                },
                new Product()
                {
                    Id = 5,
                    Name = "Maroon T-Shirt",
                    Description = "Lorem ipsum dolor sit amet.",
                    ImageUrl = "./Images/maroon_t-shirt.jpg",
                    CreatedDate = DateTime.Now
                },
                new Product()
                {
                    Id = 6,
                    Name = "Yellow T-Shirt",
                    Description = "Lorem ipsum dolor sit amet.",
                    ImageUrl = "./Images/yellow_t-shirt.jpg",
                    CreatedDate = DateTime.Now
                });
        }
    }
}
