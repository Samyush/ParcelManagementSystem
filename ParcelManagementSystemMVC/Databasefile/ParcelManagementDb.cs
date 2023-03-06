using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ParcelManagementSystemMVC.Models;

namespace ParcelManagementSystemMVC.Databasefile
{
    public class ParcelManagementDb : DbContext
    {
        public  ParcelManagementDb(DbContextOptions options) :base(options) { }
        
        public DbSet<ParcelManagement> ParcelManagements { get; set; }  
        public DbSet<forgotpassword> forgotpasswords { get; set; }
        //set database tables with initial data

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<forgotpassword>().HasData(
                new forgotpassword
                {
                    forgot_id = 1,
                    new_password = "",
                    conform_password = "",
                }
                
                );
        }
    }

}
