using App04_model.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace App04_model.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult senddept(int department)
        {
            ViewBag.department = department;
            return View();
        }
        public IActionResult dept()
        {
            List<Department> list=new List<Department>();
            list.Add(new Department { Id = 1, Name = "Human Resource" });
            list.Add(new Department { Id = 2, Name = "Accounts" });
            list.Add(new Department { Id = 1, Name = "Administration" });
            list.Add(new Department { Id = 1, Name = "Sales & Marketing" });
            list.Add(new Department { Id = 1, Name = "Information Technology" });
            list.Add(new Department { Id = 1, Name = "Production" });

            return View(list);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}