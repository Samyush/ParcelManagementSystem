using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParcelManagementSystemMVC.Models;

namespace ParcelManagementSystemMVC.Controllers
{
    public class AddBranchController : Controller
    {
        private readonly ParcelDbContext _context;

        public AddBranchController(ParcelDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddBranch()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddBranch([Bind("id, Branch_name, Branch_code, State, Street,City,Zip_code")] Branch branch)
        {
            if (ModelState.IsValid)
            {
                _context.Add(branch);
                TempData["error"] = "Record Save";
                _context.SaveChanges();
                return RedirectToAction("BranchList");
            }
            else
            {
                TempData["error"] = "Empty Field";
                return View(branch);
            }

        }

        [HttpGet]
        public IActionResult BranchList()

        {
            var branch = _context.Branchs.ToList();
            return View(branch);

        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Branchs == null)
            {
                return NotFound();
            }
            var branch = await _context.Branchs.FirstOrDefaultAsync(m => m.id == id);
            if (branch == null)
            {
                return NotFound();
            }

            return View(branch);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Branchs == null)
            {
                return NotFound();
            }
            var branch = await _context.Branchs.FirstOrDefaultAsync(m => m.id == id);
            if (branch == null)
            {
                return NotFound();
            }
            return View(branch);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteFirmed(int id)

        {
            if (_context.Branchs == null)
            {
                return Problem("their was a problem");
            }
            var brn = await _context.Branchs.FindAsync(id);
            if (brn != null)
            {
                _context.Branchs.Remove(brn);
            }

            await _context.SaveChangesAsync();
            TempData["error"] = "Record Deleted";
            return RedirectToAction(nameof(BranchList));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Branchs == null)
            {
                return NotFound();
            }
            var branch = await _context.Branchs.FindAsync(id);
            if (branch == null)
            {
                return NotFound();
            }
            return View(branch);

        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("id, Branch_name, Branch_code, State, Street, City, Zip_code")] Branch branch)
        {
            if (id != branch.id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(branch);
                    await _context.SaveChangesAsync();
                    TempData["error"] = "Record Updated";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!branchExits(branch.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }

                }
                return RedirectToAction(nameof(BranchList));
            }
            return View(branch);
        }

            private bool branchExits(int id)
            {
                return (_context.Branchs?.Any(e => e.id == id)).GetValueOrDefault();
            }


        }
}
