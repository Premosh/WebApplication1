using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CookieController : Controller
    {
        public IActionResult Index()
        {
            // Read cookies from request object
            string userName = Request.Cookies["USName"] ?? string.Empty; // Handle possible null value
            return View("Index", userName);
        }
        [HttpPost]
        public IActionResult Index(IFormCollection form)
        {
            string userName = form["userName"].ToString();
            //create a cookie
            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddMinutes(10); // Set cookie expiration to 10 minutes
            Response.Cookies.Append("USName", userName, options);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult DeleteCookies()
        {
            //delete cookie
            Response.Cookies.Delete("USName");
            return RedirectToAction(nameof(Index));

        }
        public IActionResult GetQueryString(string name, int age)
        {
            TempData["Name"] = name; // Store data in TempData
            TempData["Age"] = age; // Store another piece of data
            return View();
        }
        public IActionResult HiddenFieldExample()
        {
            StudentDetails sd = new StudentDetails();
            sd.UserID = 1;
            sd.Name = "John Doe";
            sd.Email = "johndoe@example.com";
            return View(sd);
        }
    }
}
