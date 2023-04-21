using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext(IConfiguration configuration) 
        {
            Configuration = configuration;
        }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {}

        protected readonly IConfiguration Configuration;

 
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to mysql with connection string from app settings
            var connection = Configuration["MySQLConnection:MySQLConnectionString"];
            
            options.UseMySql(connection, ServerVersion.AutoDetect(connection));
        }

        public DbSet<Product> Products { get; set;}

    }
}
