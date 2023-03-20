using Microsoft.AspNetCore.Mvc;

namespace ParcelManagementSystemMVC.Controllers
{
    public class UserController : Controller
    {

        //LoginPage
        public IActionResult LoginPage()
        {
            return View();
        }
        
        //RegisterPage
        public IActionResult RegisterPage()
        {
            return View();
        }
        
        //ForgotPasswordPage
        public IActionResult ForgotPasswordPage()
        {
            return View();
        }
    }
}
