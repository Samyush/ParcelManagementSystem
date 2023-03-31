using Microsoft.AspNetCore.Mvc;

namespace ParcelManagementSystemMVC.Controllers
{
    public class ParcelController : Controller
    {
        public IActionResult DashBoard()
        {
            return View();
        }
        public IActionResult AddParcel()
        {
            return View();
        }
        public IActionResult ParcelList()
        {
            return View();
        }
        public IActionResult TrackParcel()
        {
            return View();
        }
        public IActionResult UpdateParcelStatus()
        {
            return View();
        }
    }
}
