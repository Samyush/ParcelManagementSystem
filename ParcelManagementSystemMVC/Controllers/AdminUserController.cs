using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParcelManagementSystemMVC.Models;

namespace ParcelManagementSystemMVC.Controllers
{
    public class AdminUserController : Controller
    {
        private readonly ParcelDbContext _context;

        public AdminUserController(ParcelDbContext context)
        {
            _context = context;
        }
        public IActionResult DashBoard()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddUser()
        {
            return View();

        }
        [HttpPost]
        public IActionResult AddUser(Users user)
        {
            if (ModelState.IsValid)
            {
                var usr = new Users()
                {

                };
            }
            return View();
        }
        [HttpGet]
        public IActionResult UserList()
        {
            return View();
        }

        public IActionResult AccessAdmin()
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

