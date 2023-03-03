using Microsoft.EntityFrameworkCore;

namespace ParcelManagementSystemMVC.DataDB
{
    public class logindb :DbContext
    {
        public logindb(DbContextOptions options) : base(options)
        { }
    }
    public DbSet<loginclass> Loginclass { get; set; }

}
