using Courses.Models;
using Courses.Repositories;
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
        private readonly IStudentRepository _student;
        private readonly IMaterialRepository _material;


        public HomeController(
            ILogger<HomeController> logger,
            ICourseRepository course,
            IInstructorRepository instructor,
            IStudentRepository student,
            IMaterialRepository material
            )
        {
            _logger = logger;
            _course = course;
            _instructor = instructor;
            _student = student;
            _material = material;
        }

        public IActionResult Index()
        {
            ViewBag.CountInstructor = _instructor.GetCountInstructor();
            ViewBag.CountStudent = _student.GetCountStudent();
            ViewBag.CountCourse = _course.GetCountCourse();
            return View();
        }

        public IActionResult Courses()
        {
            var course = _course.GetAllByInclude().OrderBy(c => c.Title);

            return View(course);
        }

        public IActionResult Details(int id)
        {
            var details = _material.GetCourseWithMaterial(id);
            return View(details);

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
           
        public IActionResult CreateStudent()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateStudent(Student student)
        {
            _student.Add(student);
            return RedirectToAction("Courses");
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
