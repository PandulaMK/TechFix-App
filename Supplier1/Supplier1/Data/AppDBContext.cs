using Microsoft.EntityFrameworkCore;
using Supplier1.Model;
namespace Supplier1.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        //You need to do this for each Model in model folder 
        //Section 1
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderRequest> OrderRequests { get; set; }
        //End Section 1

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //For each list you define on section 1 need to do this
            //For decimal it must do this for other types you can give sql sever data types or let Entity framework to pick best matching type
            modelBuilder.Entity<Product>().Property(p => p.Price).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Product>().Property(p => p.ProductName).HasColumnType("varchar(200)");
            modelBuilder.Entity<Order>().Property(o => o.TotalPrice).HasColumnType("decimal(18,2)");

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conn = "Data Source=PANDULA_ASUS;Initial Catalog=Supplier1;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            optionsBuilder.UseSqlServer(conn);
        }
    }
}

