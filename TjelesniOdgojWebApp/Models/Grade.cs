using System;

namespace TjelesniOdgojWebApp.Models
{
    public class Grade
    {
        public int StudentId { get; set; }
        public int Value { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        
        public Grade(int studentId, int value)
        {
            StudentId = studentId;
            Value = value;
        }
    }
}
