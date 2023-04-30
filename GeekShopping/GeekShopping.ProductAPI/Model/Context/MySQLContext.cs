using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() { }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Product> Products { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Moletom Cobra Kay",
                Price = new decimal(69.9),
                Description = "Description",
                ImageUrl = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/27ab0becda80bca82da59de96356da15f8bc0c80/ShoppingImages/8_moletom_cobra_kay.jpg",
                CategoryName = "T-shirt",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Camiseta BENEFITS OF DRINKS COFFEE",
                Price = new decimal(30.9),
                Description = "Description",
                ImageUrl = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/27ab0becda80bca82da59de96356da15f8bc0c80/ShoppingImages/7_coffee.jpg",
                CategoryName = "T-shirt",
            });
        }

    }
}
