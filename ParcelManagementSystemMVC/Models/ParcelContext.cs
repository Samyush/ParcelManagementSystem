using Microsoft.EntityFrameworkCore;

namespace ParcelManagementSystemMVC.Models
{
    public class ParcelContext:DbContext
    {
        public ParcelContext(DbContextOptions options):base(options) { 
        
        }
        public DbSet<Parcel> Parcels { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Branch> Branches { get; set; }

    }
}
