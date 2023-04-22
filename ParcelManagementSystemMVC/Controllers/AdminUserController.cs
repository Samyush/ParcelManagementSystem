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
                users.DateCreated=DateTime.Now.ToLocalTime();
                users.IsActive=true;
                users.IsDeleted = false;
                users.CreatedBy = "Default";
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

        public IActionResult EditUser(int? Id)
        {
            var user = _context.Users.Find(Id);
            if (Id == null || _context.Users == null)
            {
                return NotFound();
            }
            
            return View(user);
        }
        [HttpPost]
        public IActionResult EditUser(Users user,int? Id)
        {

            if (user.Id != Id)
            {
                return NotFound();
            }

            Users olduser = _context.Users.Find(Id);
            Users updateuser = new Users();
            updateuser = user;
            updateuser.UserName = olduser.UserName;
            updateuser.UserPassword = olduser.UserPassword;
            updateuser.DateCreated = olduser.DateCreated;
            updateuser.IsDeleted = olduser.IsDeleted;
            updateuser.IsActive = olduser.IsActive;
            updateuser.CreatedBy = olduser.CreatedBy;

            updateuser.DateUpdated = DateTime.Now;
            updateuser.UpdatedBy = "Updatedusers";
            _context.Users.Remove(olduser);
            _context.Users.Update(updateuser);
            _context.SaveChanges();
            return RedirectToAction(nameof(UserList));


        }
        
        public IActionResult DeleteUser(int? Id)
        {
            var user = _context.Users.Find(Id);
            if (Id == null || _context.Users == null)
            {
                return NotFound();
            }

            return View(user);
        }
        
        public IActionResult DeleteUserConfirm(int? Id)
        {
            if (Id == null || _context.Users == null)
            {
                return NotFound();
            }
            var user = _context.Users.Find(Id);
            if (user == null)
            {
                return NotFound();
            }
            _context.Users.Remove(user);
            _context.SaveChanges();
            return RedirectToAction(nameof(UserList));
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