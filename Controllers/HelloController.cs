using KhufiyaProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace KhufiyaProject.Controllers
{
    public class HelloController : Controller
    {
        public HelloController()
        {
        }

        public IActionResult Index()
        {
            TempData["Location"] = "India";
            return View();
        }

        public IActionResult Student()
        {
            Student student = new Student
            {
                Id = 1,
                Name = "Fardin shaikh",
                Gender = "male"
            };
            ViewBag.CurrentDate = DateTime.Now.ToShortDateString();
            ViewData["Title"] = "Mr.fardin shaikh";
            string? location = Convert.ToString(TempData["Location"]);
            return View(student);
        }
    }
}
