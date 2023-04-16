using Microsoft.AspNetCore.Mvc;
using ParcelManagementSystemMVC.Data;
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
        public IActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddUser(Users users)
        {

            if (users != null)
            {
                _context.Users.Add(users);
                _context.SaveChanges();
                return RedirectToAction("UserList");
            }

            return View();


        }
        public IActionResult UserList()
        {
            var users = _context.Users;
            return View(users.ToList());
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

        public IActionResult AddBranch()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddBranch(Branch branch)
        {
            if (branch != null)
            {
                _context.Branch.Add(branch);
                _context.SaveChanges();
                return RedirectToAction("BranchList");
            }

            return View();
        }
        public IActionResult BranchList()

        {
            var branch = _context.Branch;
            return View(branch.ToList());

        }
    }
}

