using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EntityCodeFirst.Models;

namespace EntityCodeFirst.Controllers
{
    public class HomeController : Controller
    {
        public StudentContext db = new StudentContext();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Student> students = db.Students.ToList();
            ViewBag.list = students;
            return View();
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

        // this is for handling the form input
        public IActionResult Create(Student s)
        {
            if(ModelState.IsValid)
            {
                db.Students.Add(s);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
