using Microsoft.EntityFrameworkCore;
using ParcelManagementSystemMVC.DBContext.User;
using System.Collections.Generic;

namespace ParcelManagementSystemMVC.DBContext.Parcel
{
    public class ParcelDBContext : DbContext
    {
        public ParcelDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Parcel> Parcels { get; set; }
        public DbSet<User.User> Users { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<ParcelPackage> ParcelPackages { get; set; }
        public DbSet<HistoryofParcel> ParcelHistory { get; set; }

        public DbSet<ParcelCharges> Charges { get; set; }

    }
}
