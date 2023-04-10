using Microsoft.AspNetCore.Mvc;

namespace ParcelManagementSystemMVC.Controllers
{
    public class AdminUserController : Controller
    {
        public IActionResult DashBoard()
        {
            return View();
        }
        public IActionResult AddUser()
        {
            return View();
        }
        
        public IActionResult AddRole()
        {
            return View();
        }
        public IActionResult RoleList()
        {
            return View();
        }

    }
}

