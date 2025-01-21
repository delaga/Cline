namespace TjelesniOdgojApp
{
    public class Report
    {
        public int StudentId { get; set; }
        public List<Grade> Grades { get; set; } = new();
        public List<Note> Notes { get; set; } = new();
        
        public Report(int studentId)
        {
            StudentId = studentId;
        }
        
        public string Generate()
        {
            var report = $"Izvještaj za učenika ID: {StudentId}\n";
            report += "Ocjene:\n";
            foreach (var grade in Grades)
            {
                report += $"- {grade.Value} ({grade.Date.ToShortDateString()})\n";
            }
            
            report += "\nNapomene:\n";
            foreach (var note in Notes)
            {
                report += $"- {note.Content} ({note.Date.ToShortDateString()})\n";
            }
            
            return report;
        }
    }
}
