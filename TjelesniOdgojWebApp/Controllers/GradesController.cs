using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TjelesniOdgojWebApp.Models;

namespace TjelesniOdgojWebApp.Controllers
{
    public class GradesController : Controller
    {
        private static List<Grade> grades = new();

        public IActionResult Index(int studentId)
        {
            var studentGrades = grades.FindAll(g => g.StudentId == studentId);
            ViewBag.StudentId = studentId;
            return View(studentGrades);
        }

        public IActionResult Create(int studentId)
        {
            ViewBag.StudentId = studentId;
            return View();
        }

        [HttpPost]
        public IActionResult Create(int studentId, Grade grade)
        {
            grade.StudentId = studentId;
            grades.Add(grade);
            return RedirectToAction(nameof(Index), new { studentId });
        }
    }
}
