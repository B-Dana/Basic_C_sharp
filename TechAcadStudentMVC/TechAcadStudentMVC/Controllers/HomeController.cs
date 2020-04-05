using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechAcadStudentMVC.Models;

namespace TechAcadStudentMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Instructor(int id)
        {
            ViewBag.Id = id;
            Instructor dayTimeInstructor = new Instructor()
            {
                Id = 1,
                FirstName = "Erik",
                LastName = "Gross"
            };
            return View(dayTimeInstructor);
        }

        public IActionResult Instructors()
        {
            List<Instructor> instructors = new List<Instructor>
            {
                new Instructor
                {
                    Id=1,
                    FirstName="Rick",
                    LastName="Ramen"
                },
                new Instructor
                { 
                    Id=2,
                    FirstName="Brett",
                    LastName="Calendar"
                },
                new Instructor
                {
                    Id=1,
                    FirstName="Adam",
                    LastName="Smithsonian"
                }
            };
            return View(instructors);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
    }
}
