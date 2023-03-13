using Microsoft.EntityFrameworkCore;
using ParcelManagementSystemMVC.Data;

var builder = WebApplication.CreateBuilder(args);

//*builder.Services.AddDbContext<ParcelMgmtContext>(options =>
//{
//  options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

//});
builder.Services.AddControllersWithViews();
var provider = builder.Services.BuildServiceProvider();
var configuration = provider.GetService<IConfiguration>();
builder.Services.AddDbContext<ParcelDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
var app = builder.Build();

// Add services to the container.

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
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();