using Microsoft.EntityFrameworkCore;
using ParcalManagementSystemMVC.DBContext;
using System.Collections.Generic;

namespace ParcelManagementSystemMVC.DBContext
{
    public class ParcelDBContext : DbContext
    {
        public ParcelDBContext(DbContextOptions options) : base(options) { 
        }
        public DbSet<Parcel> Parcels { get; set; }
        public DbSet<NewUser> Users { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<ParcelPackage> ParcelPackages { get; set; }
        public DbSet<ParcelReceiver> Receiver { get; set; }
        public DbSet<ParcelSender> Sender { get; set; }
        public DbSet<AdminRole> AdminRole { get; set; }
        public DbSet<AdminUser> AdminUser { get; set; }
        public DbSet<Setting> Setting { get; set; }
        public DbSet<ParcelCharges> Charges { get; set; }


    }
}
