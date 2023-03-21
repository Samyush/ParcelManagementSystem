using Microsoft.AspNetCore.Mvc;

namespace ParcelManagementSystemMVC.Controllers;

public class ParcelManagementController : Controller
{
    // GET
    public IActionResult HomePage()
    {
        return View();
    }
}