using Microsoft.EntityFrameworkCore;

namespace ParcelManagementSystemMVC.Database
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext> options) : base(options)
        {
        }
        public DbSet<Package> Package { get; set; }
    }
}
