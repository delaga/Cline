using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TjelesniOdgojWebApp.Models;

namespace TjelesniOdgojWebApp.Controllers
{
    public class StudentsController : Controller
    {
        private static List<Student> students = new();

        public IActionResult Index()
        {
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            students.Add(student);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            var student = students.Find(s => s.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }
    }
}
