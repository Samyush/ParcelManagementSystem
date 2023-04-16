//string[] arg = {"","","","","","","" };


using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ParcelManagementSystemMVC.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ParcelDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddIdentity<IdentityUser,IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ParcelDbContext>();

//builder.Services.AddDbContext<ParcelDbContext>(){x => x. };
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();





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
app.UseAuthentication();;

app.UseAuthorization();
app.MapRazorPages();
app.MapControllerRoute(
    "default",
    "{controller=Home}/{action=Index}/{id?}");

app.Run();