using Microsoft.EntityFrameworkCore;

namespace RiedoShopping.ProductApi.Model.Context
{
    public class PostgresContext : DbContext
    {
        public PostgresContext(){}
        public PostgresContext(DbContextOptions<PostgresContext> options) : base(options){}

        public DbSet<Product> Products { get; set;}
    }
}
