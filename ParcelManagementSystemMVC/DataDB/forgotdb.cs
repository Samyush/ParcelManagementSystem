using Microsoft.EntityFrameworkCore;

namespace ParcelManagementSystemMVC.DataDB
{
    public class forgotdb:DbContext
    {
        public forgotdb(DbContextOptions<forgotdb> options) : base(options)
        {

        }
        public DbSet<forgotdb> Forgotdb { get; set; }

    }
}
