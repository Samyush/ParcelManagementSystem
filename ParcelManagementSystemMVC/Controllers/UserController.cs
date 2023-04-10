using Microsoft.AspNetCore.Mvc;

namespace ParcelManagementSystemMVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult AddUser()
        {
            return View();
        }
        public IActionResult UserList()
        {
            return View();
        }
    }
}
