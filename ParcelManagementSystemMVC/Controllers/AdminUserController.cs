using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting.Internal;
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
            Users u = new Users();
         
            return View(u);


        }
        [HttpPost]
        public async Task<IActionResult> AddUser ( Users ui, IFormFile file)
        {
            Users u = new Users();
            if (file == null || file.Length==0) 
            {
                u.Imagefile = "noimage.png";


            }else
            {
                string filename = System.Guid.NewGuid().ToString() + ".jpg";
                var path = Path.Combine(
                    Directory.GetCurrentDirectory(), "wwwroot", "img", filename);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);

                }
                u.Imagefile = filename;
            }
            u.FirstName = ui.FirstName;
            u.LastName=ui.LastName;
            u.Street=ui.Street;
            u.City=ui.City;
            u.State=ui.State;
            u.Country=ui.Country;
            u.PhoneNumber=ui.PhoneNumber;
            u.Email=ui.Email;
            u.IsExternal=ui.IsExternal;
            u.UserName=ui.UserName;
            u.UserPassword=ui.UserPassword;
            u.AccessRole=ui.AccessRole;
           _context.Add(u);
            await _context.SaveChangesAsync();
            return RedirectToAction("UserList");            
           

        }
        
       
        [HttpGet]
        public IActionResult UserList()
        {
            var user = _context.Users;
            return View (user.ToList());
        }

        public IActionResult AccessAdmin()
        {
            return View();
        }

       
        
    }
        
    
}

