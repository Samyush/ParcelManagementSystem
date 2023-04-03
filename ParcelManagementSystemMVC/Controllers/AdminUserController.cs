using Microsoft.AspNetCore.Mvc;

namespace ParcelManagementSystemMVC.Controllers
{
    public class AdminUserController : Controller
    {
        public IActionResult DashBoard()
        {
            return View();
        }
    }
}

