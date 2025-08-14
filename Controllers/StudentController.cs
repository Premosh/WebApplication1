using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Create(StudentDetails st)
        {
            if (ModelState.IsValid)
            {
                return View("Details",st);
            }
            return View();
        }
        public IActionResult Details(StudentDetails st)
        {
            return View(st);
        }
    }
}
