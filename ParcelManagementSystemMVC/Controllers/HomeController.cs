using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ParcelManagementSystemMVC.DBContext;
using ParcelManagementSystemMVC.Models;

namespace ParcelManagementSystemMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ParcelDBContext _parcelDBContext;
    public HomeController(ILogger<HomeController> logger, ParcelDBContext parcelDBContext)
    {
        _logger = logger;
        _parcelDBContext = parcelDBContext;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}