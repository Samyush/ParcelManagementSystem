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
    public DbSet<Branchdetails> Branchdbs { get; set; }
   public DbSet<staff_details> totalStaffdbs { get; set; }
    public DbSet<Roles> rolesdbs { get; set; }
    public DbSet<jobtitles> jobtitledbs { get; set; }
    public DbSet<Branch> branches { get; set; }
   public DbSet<Packagedb> packagedbs { get; set; }
  public DbSet<Chargedb> chargedbs { get; set; }
  public DbSet<UpdateParcel> UpdateParcel { get; set; }
  public DbSet<HistoryParcel> HistoryParcel { get; set; }
    public DbSet<Receiverdetails> receiverdetail { get; set; }
    public DbSet<Senderdetails> senderdetail { get; set; }
    public DbSet<staff>staff { get; set; }

}