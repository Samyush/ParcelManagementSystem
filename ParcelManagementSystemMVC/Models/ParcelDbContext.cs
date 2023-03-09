using Microsoft.EntityFrameworkCore;

namespace ParcelManagementSystemMVC.Models;

public class ParcelDbContext : DbContext
{
    public ParcelDbContext(DbContextOptions<ParcelDbContext> options) : base(options)
    {
    }

    public DbSet<Users> Users { get; set; }
    public DbSet<Parcels> Parcels { get; set; } 
}