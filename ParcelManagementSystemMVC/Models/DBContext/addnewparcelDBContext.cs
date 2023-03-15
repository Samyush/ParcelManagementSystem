using Microsoft.EntityFrameworkCore;

namespace ParcelManagementSystemMVC.Models.DBContext
{
    public class addnewparcelDBContext : DbContext

    {
        public addnewparcelDBContext(DbContextOptions options) : base(options) 
        {
        }
        public DbSet<parceltable> parceltable { get; set; }
        public DbSet<locationtable> locationtable { get; set; }
        public DbSet<usertable> usertable { get; set; }
        public DbSet<pricetable> pricetable { get; set; }
        public DbSet<statustable> statustable { get; set; }
        
    }
}
