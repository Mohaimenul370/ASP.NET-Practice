using App04_model.Models;
using Microsoft.AspNetCore.Mvc;

namespace App04_model.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RegForm(Student std)
        {
            if (ModelState.IsValid)
            {
                ViewBag.name = std.stdName.ToUpper();
                return View("Submitted");
            }
            ViewBag.name = std.stdName;
            ViewBag.email = std.stdEmail;
            ViewBag.mobile = std.stdMobile;

            ViewBag.msg = "Please Enter Valid Data";
            return View("Index");
        }
        
    }
}
