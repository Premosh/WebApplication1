using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserDetails ud)
        {
            if(ModelState.IsValid)
            {
                if (ud.UserName == "admin" && ud.Password == "password")
                {
                   return View("Dashboard", ud);
                }
                else
                {
                    TempData["ErrorMessage"] = "Invalid username or password.";
                    return View();
                }
            }
            return View();
        }
        public IActionResult Dashboard(UserDetails ud)
        {
            return View(ud);
        }
    }
}
