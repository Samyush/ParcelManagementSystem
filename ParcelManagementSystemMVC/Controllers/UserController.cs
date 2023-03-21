using Microsoft.AspNetCore.Mvc;

namespace ParcelManagementSystemMVC.Controllers
{
    public class UserController: Controller
    {
         public IActionResult TrackParcel ()
        {
            return View("LoginPage");
        }


    }
}
