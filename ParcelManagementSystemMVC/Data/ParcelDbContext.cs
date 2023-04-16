using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ParcelManagementSystemMVC.Models;

namespace ParcelManagementSystemMVC.Data;

public class ParcelDbContext : IdentityDbContext
{
    public ParcelDbContext(DbContextOptions<ParcelDbContext> options) : base(options)
    {
        
    }
    public DbSet<Users> Users { get; set; }
    public DbSet<Branch> Branch { get; set; }

}