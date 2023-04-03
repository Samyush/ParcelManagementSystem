using Microsoft.EntityFrameworkCore;

using ParcelManagementSystemMVC.DBContext.User;

using ParcelManagementSystemMVC.DBContext.Parcel;


using System.Collections.Generic;
using ParcelManagementSystemMVC.DBContext.Parcels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ParcelManagementSystemMVC.DBContext.Parcel
{
    public class ParcelDBContext : IdentityDbContext
    {

        public ParcelDBContext(DbContextOptions options) : base(options)
        {

      
            Database.EnsureCreated();

        }
        public DbSet<Parcel> Parcel { get; set; }
        public DbSet<User.User> Users { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<ParcelPackage> ParcelPackages { get; set; }

        public DbSet<HistoryofParcel> ParcelHistory { get; set; }
        public DbSet<Receiver> Receiver { get; set; }
        public DbSet<Sender> Sender { get; set; }


        public DbSet<AdminUser>  AdminUser { get; set; }
        public DbSet<ParcelCharges> Charges { get; set; }




    }
}
