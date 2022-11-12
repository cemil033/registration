using Microsoft.AspNetCore.Mvc;
using RegistrationPage.Models;

namespace RegistrationPage.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(User users)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            return Redirect("Registration/Welcome");
        }
    }
}
