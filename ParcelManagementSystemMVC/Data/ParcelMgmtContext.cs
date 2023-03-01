using Microsoft.EntityFrameworkCore;
using System;


public class ParcelMgmtContext : DbContext
{
	public ParcelMgmtContext(DbContextOptions<ParcelMgmtContext> options): base(options) { }

    public DbSet<userList> ListofUsers{ get; set; }
}
