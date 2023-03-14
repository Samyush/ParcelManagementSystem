using Microsoft.EntityFrameworkCore;

namespace ParcelManagementSystemMVC.Models;

public class ParcelDbContext : DbContext
{
    public ParcelDbContext(DbContextOptions<ParcelDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<Users> Users { get; set; }
    public DbSet<Parcels> Parcels { get; set; }
    public DbSet<Branch> Branches { get; set; }
    public DbSet<Charges> Charges { get; set; }
    public DbSet<ParcelStatus> ParcelStatuses { get; set; }
    public DbSet<Roles> Roles { get; set; }

}