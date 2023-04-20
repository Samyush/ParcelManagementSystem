using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParcelManagementSystemMVC.Models;
using System.Reflection.Metadata.Ecma335;

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
        [HttpGet]
        public IActionResult AddBranch()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBranch(Branch branch)
        {
            if (ModelState.IsValid)
            {
                var brn = new Branch()
                {
                    Branch_name = branch.Branch_name,
                    Branch_code = branch.Branch_code,
                    State = branch.State,
                    Street = branch.Street,
                    City = branch.City,
                    Zip_code = branch.Zip_code,
                };
                _context.Branchs.Add(brn);
                TempData["error"] = "Record Save";
                _context.SaveChanges();
                return RedirectToAction("BranchList");
            }
            else
            {
                TempData["error"] = "Empty Field";
                return View( branch);
            }

        }
        public IActionResult BranchList()

        {
            var branch = _context.Branchs;
            return View(branch.ToList());
        }
        public IActionResult Delete(int id)

        {
            var brn =_context.Branchs.SingleOrDefault(e=> e.id == id);  
            _context.Branchs.Remove(brn);
            _context.SaveChanges();
            TempData["error"] = "Record Deleted";
            return RedirectToAction("BranchList");
        }
        [HttpGet]
        public IActionResult Edit (int id)
        {
            var brn =_context.Branchs.SingleOrDefault(e=> e.id== id);
            var result = new Branch()
            {
                Branch_name = brn.Branch_name,
                Branch_code = brn.Branch_code,
                State = brn.State,
                Street = brn.Street,
                City = brn.City,
                Zip_code = brn.Zip_code,
            };
            return View(result);
        }
        [HttpPost]
        public IActionResult Edit(Branch branch)
        {
            var brn = new Branch()
            {
                id= branch.id,
                Branch_name = branch.Branch_name,
                Branch_code = branch.Branch_code,
                State = branch.State,
                Street = branch.Street,
                City = branch.City,
                Zip_code = branch.Zip_code,
            };
            _context.Branchs.Update(brn);
            _context.SaveChanges();
            TempData["error"] = "Record Updated";
            return RedirectToAction("BranchList");
        }
    }
}

