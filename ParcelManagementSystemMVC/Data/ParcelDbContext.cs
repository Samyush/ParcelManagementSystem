using Microsoft.EntityFrameworkCore;
using ParcelManagementSystemMVC.Models;

namespace ParcelManagementSystemMVC.Data
{
    public class ParcelDbContext : DbContext
    {
        public ParcelDbContext(DbContextOptions<ParcelDbContext> options) : base(options)
        {
            
        }

        public DbSet<userList> ListofUsers { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Parcels> Parcelss { get; set; }
        public DbSet<HistoryofParcel> HOP { get; set; }

    }
}
