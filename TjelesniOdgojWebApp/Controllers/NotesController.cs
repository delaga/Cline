using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TjelesniOdgojWebApp.Models;

namespace TjelesniOdgojWebApp.Controllers
{
    public class NotesController : Controller
    {
        private static List<Note> notes = new();

        public IActionResult Index(int studentId)
        {
            var studentNotes = notes.FindAll(n => n.StudentId == studentId);
            ViewBag.StudentId = studentId;
            return View(studentNotes);
        }

        public IActionResult Create(int studentId)
        {
            ViewBag.StudentId = studentId;
            return View();
        }

        [HttpPost]
        public IActionResult Create(int studentId, Note note)
        {
            note.StudentId = studentId;
            notes.Add(note);
            return RedirectToAction(nameof(Index), new { studentId });
        }
    }
}
