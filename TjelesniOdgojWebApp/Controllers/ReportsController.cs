using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TjelesniOdgojWebApp.Models;

namespace TjelesniOdgojWebApp.Controllers
{
    public class ReportsController : Controller
    {
        public IActionResult StudentReport(int studentId)
        {
            // Dohvati podatke o učeniku
            var student = StudentsController.students.Find(s => s.Id == studentId);
            
            // Dohvati ocjene
            var grades = GradesController.grades.FindAll(g => g.StudentId == studentId);
            
            // Dohvati napomene
            var notes = NotesController.notes.FindAll(n => n.StudentId == studentId);
            
            ViewBag.Student = student;
            ViewBag.Grades = grades;
            ViewBag.Notes = notes;
            
            return View();
        }
    }
}
