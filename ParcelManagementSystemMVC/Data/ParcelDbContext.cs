using Microsoft.EntityFrameworkCore;
using ParcelManagementSystemMVC.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ParcelManagementSystemMVC.Data
{
    public class ParcelDbContext : DbContext
    {
        public ParcelDbContext(DbContextOptions<ParcelDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Send_Rec>().HasKey(sd => new
            {
                sd.SenderId,
                sd.ReceiverId
            }
            );
            modelBuilder.Entity<Send_Rec>().HasOne(s=>s.Senders).WithMany(sd=>sd.Sender_Receiver).HasForeignKey(sd=>sd.SenderId);
            modelBuilder.Entity<Send_Rec>().HasOne(s => s.Receivers).WithMany(sd => sd.Sender_Receiver).HasForeignKey(sd => sd.ReceiverId);

            
        }

        public DbSet<userList> ListofUsers { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Parcels> Parcels { get; set; }
        public DbSet<HistoryofParcel> HOP { get; set; }
        public DbSet<Sender> Senders { get; set; }
        public DbSet<Receiver> Receivers { get; set; }
        public DbSet<Send_Rec> Sender_Receiver { get; set; }
       
         public DbSet<Role> Roles { get; set; }

    }
}
