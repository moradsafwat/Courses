using Course.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICourseRepository _course;
        private readonly IInstructorRepository _instructor;

        public HomeController(
            ILogger<HomeController> logger,
            ICourseRepository course,
            IInstructorRepository instructor)
        {
            _logger = logger;
            _course = course;
            _instructor = instructor;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Courses()
        {
            //var course = db.Courses
            //    .Join(
            //    db.Instructors,
            //    course => course.InstructorId,
            //    instructor => instructor.Id,
            //    (course, instructor) => new
            //    {
            //        CourseId = course.Id,
            //        CourseTitle = course.Title,
            //        CourseDescription = course.Description,
            //        InstructorName = instructor.Name
            //    });
            //var course = _course.GetCourseWithInstructor().ToList();
            var course = _course.List();

            return View(course);
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Instructor()
        {
            var instructor = _instructor.List();
            return View(instructor);
        }

        public IActionResult Pricing()
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
