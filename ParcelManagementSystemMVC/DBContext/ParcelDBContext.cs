using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD
using ParcelManagementSystemMVC.DBContext.User;
=======
using ParcelManagementSystemMVC.DBContext.Parcels;
using ParcelManagementSystemMVC.DBContext.Users;
>>>>>>> 85b107f41a5c053c0cc18363d4e886d92a2d0902
using System.Collections.Generic;

namespace ParcelManagementSystemMVC.DBContext.Parcel
{
    public class ParcelDBContext : DbContext
    {
<<<<<<< HEAD
        public ParcelDBContext(DbContextOptions options) : base(options)
        {
=======
        public ParcelDBContext(DbContextOptions options) : base(options) {
            Database.EnsureCreated();
>>>>>>> 85b107f41a5c053c0cc18363d4e886d92a2d0902
        }
        public DbSet<Parcel> Parcels { get; set; }
        public DbSet<User.User> Users { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<ParcelPackage> ParcelPackages { get; set; }
<<<<<<< HEAD
        public DbSet<HistoryofParcel> ParcelHistory { get; set; }
=======
        public DbSet<ParcelReceiver> Receiver { get; set; }
        public DbSet<ParcelSender> Sender { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<AdminUser> AdminUser { get; set; }
        public DbSet<Setting> Setting { get; set; }
        public DbSet<ParcelCharges> Charges { get; set; }
>>>>>>> 85b107f41a5c053c0cc18363d4e886d92a2d0902

        public DbSet<ParcelCharges> Charges { get; set; }

    }
}
