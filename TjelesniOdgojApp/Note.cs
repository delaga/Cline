namespace TjelesniOdgojApp
{
    public class Note
    {
        public int StudentId { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        
        public Note(int studentId, string content)
        {
            StudentId = studentId;
            Content = content;
        }
    }
}
