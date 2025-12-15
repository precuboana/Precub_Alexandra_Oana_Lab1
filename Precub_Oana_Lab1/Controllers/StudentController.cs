using Microsoft.AspNetCore.Mvc;
using Precub_Oana_Lab1.Models;

namespace Precub_Oana_Lab1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Info()
        {
            var student = new Student { Name = "Ana", Age = 21 };

            ViewBag.Message = "Mesaj din Controller";
            ViewData["Time"] = DateTime.Now;
            return View(student);
        }
    }
}
