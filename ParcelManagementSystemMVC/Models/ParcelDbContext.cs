using Microsoft.EntityFrameworkCore;

namespace ParcelManagementSystemMVC.Models;

public class ParcelDbContext : DbContext
{
    public ParcelDbContext (DbContextOptions<ParcelDbContext> options) : base(options)
    {
       /* Database.EnsureCreated();*/
    }

    public DbSet<Users>Users{ get; set; }
    public DbSet<Parcels>Parcels{ get; set; } 
    public DbSet<Branch>Branchs{ get; set; } 
    public DbSet<Roles> roles { get; set; } 


}