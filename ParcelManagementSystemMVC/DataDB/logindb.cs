using Microsoft.EntityFrameworkCore;

namespace ParcelManagementSystemMVC.DataDB
{
    public class logindb :DbContext
    {
        public logindb(DbContextOptions <logindb> options) : base(options)
        { }

        public DbSet<loginclass> loginclass { get; set; }
    }

    

}
