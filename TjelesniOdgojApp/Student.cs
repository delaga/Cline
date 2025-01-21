namespace TjelesniOdgojApp
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ClassName { get; set; }
        
        public Student(int id, string firstName, string lastName, string className)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            ClassName = className;
        }
    }
}
