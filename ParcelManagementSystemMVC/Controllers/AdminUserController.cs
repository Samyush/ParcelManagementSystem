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
        public IActionResult UserList()
        {
            return View();
        }
        public IActionResult AddBranch()
        {
            return View();
        }
        public IActionResult BranchList()
        {
            return View();
        }
    }
}

