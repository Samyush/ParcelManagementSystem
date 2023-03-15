using Microsoft.EntityFrameworkCore;
using ParcelManagementSystemMVC.DBContext.Parcels;
using ParcelManagementSystemMVC.DBContext.Users;
using System.Collections.Generic;

namespace ParcelManagementSystemMVC.DBContext
{
    public class ParcelDBContext : DbContext
    {
        public ParcelDBContext(DbContextOptions options) : base(options) {
            Database.EnsureCreated();
        }
        public DbSet<Parcel> Parcels { get; set; }
        public DbSet<NewUser> Users { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<ParcelPackage> ParcelPackages { get; set; }
        public DbSet<ParcelReceiver> Receiver { get; set; }
        public DbSet<ParcelSender> Sender { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<AdminUser> AdminUser { get; set; }
        public DbSet<Setting> Setting { get; set; }
        public DbSet<ParcelCharges> Charges { get; set; }


    }
}
