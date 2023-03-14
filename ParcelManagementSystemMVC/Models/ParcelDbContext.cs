using Microsoft.EntityFrameworkCore;



namespace ParcelManagementSystemMVC.Models;


public class ParcelDbContext : DbContext
{
    public ParcelDbContext(DbContextOptions<ParcelDbContext> options) : base(options)
    {
        Database.EnsureCreated();

    }

    public DbSet<User> Users { get; set; }
    public DbSet<Parcels> Parcels { get; set; }

    public DbSet<Branchdb> Branchdbs { get; set; }

    public DbSet<TotalStaffdb> totalStaffdbs { get; set; }  
    
    public DbSet<historydb>historydbs { get; set; } 
    public DbSet<rolesdb>rolesdbs { get; set; }

    public DbSet<Jobtitledb>jobtitledbs { get; set; }


  



}