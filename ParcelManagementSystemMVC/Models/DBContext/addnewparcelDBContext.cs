using Microsoft.EntityFrameworkCore;

namespace ParcelManagementSystemMVC.Models.DBContext
{
    public class addnewparcelDBContext : DbContext

    {
        public addnewparcelDBContext(DbContextOptions options) : base(options) 
        {
        }
        public DbSet<addnewpparcel> addnewparcel { get; set; }
    }
}
