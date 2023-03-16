using Microsoft.EntityFrameworkCore;
using ParcelManagementSystemMVC.Models.Parcel;
using ParcelManagementSystemMVC.Models.users;

namespace ParcelManagementSystemMVC.Models;


public class ParcelDbContext : DbContext
{
    public ParcelDbContext(DbContextOptions<ParcelDbContext> options) : base(options)
    {
        Database.EnsureCreated();

    }

    public DbSet<Users> Users { get; set; }
    public DbSet<Parcels> Parcels { get; set; }
    public DbSet<Branchdb> Branchdbs { get; set; }
   public DbSet<TotalStaffdb> totalStaffdbs { get; set; }
    public DbSet<Rolesdb> rolesdbs { get; set; }
    public DbSet<Jobtitledb> jobtitledbs { get; set; }
    public DbSet<Packagedb> packagedbs { get; set; }
   public DbSet<Chargedb> chargedbs { get; set; }
    public DbSet<UpdateParcel> UpdateParcel { get; set; }
    public DbSet<Actiondb> actiondb { get; set; }
    public DbSet<HistoryParcel> HistoryParcel { get; set; }

}