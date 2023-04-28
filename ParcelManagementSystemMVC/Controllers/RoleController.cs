using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParcelManagementSystemMVC.Models;

namespace ParcelManagementSystemMVC.Controllers
{
    
    public class RoleController : Controller
    {
        private readonly ParcelDbContext _context;
        public RoleController (ParcelDbContext context)
        {
            _context = context; 
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddRole()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> AddRole([Bind("id, name, status")] Roles role)
        {
                var data = new Roles
                {
                    name= role.name,
                    status = role.status,
                };
                _context.roles.Add(data);
                _context.SaveChanges();
                return RedirectToAction("RoleList");
        }

        public IActionResult RoleList()
        {

            var role = _context.roles.ToList();
            return View(role);
        }

        public async Task<IActionResult> Delete()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? Id)
        {
            if (Id == null || _context.roles == null)
            {
                return NotFound();
            }
            var role = await _context.roles.FindAsync(Id);
            if (role == null)
            {
                return NotFound();
            }
            return View(role);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int Id, [Bind("Id, Name, Status")] Roles role)
        {

            if (Id != role.id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(role);
                    await _context.SaveChangesAsync();
                    TempData["error"] = "Record Updated";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!editrole(role.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }

                }
                return RedirectToAction(nameof(RoleList));
            }
            return View(role);
        }
            private bool editrole(int id)
            {
                return (_context.roles?.Any(e => e.id == id)).GetValueOrDefault();
            }
    }
}
