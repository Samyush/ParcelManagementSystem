//string[] arg = {"","","","","","","" };


using Microsoft.EntityFrameworkCore;
using ParcelManagementSystemMVC.Database;
using ParcelManagementSystemMVC.Models;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddDbContext<ParcelDbContext>(){x => x. };
// Add services to the container.
builder.Services.AddControllersWithViews();

//var provider = builder.Services.BuildServiceProvider();
//var configuration = provider.GetRequiredService<IConfiguration>();
builder.Services.AddDbContext<ProductDBContext>(item => item.UseSqlServer(builder.Configuration.GetConnectionString("myconn")));





var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    "default",
    "{controller=Home}/{action=Index}/{id?}");

app.Run();