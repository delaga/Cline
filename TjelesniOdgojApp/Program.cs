using System;
using System.Collections.Generic;

namespace TjelesniOdgojApp
{
    class Program
    {
        static List<Student> students = new();
        static List<Grade> grades = new();
        static List<Note> notes = new();
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nTjelesni odgoj - glavni izbornik");
                Console.WriteLine("1. Dodaj učenika");
                Console.WriteLine("2. Upisi ocjenu");
                Console.WriteLine("3. Dodaj napomenu");
                Console.WriteLine("4. Generiraj izvještaj");
                Console.WriteLine("5. Izlaz");
                Console.Write("Odabir: ");
                
                var choice = Console.ReadLine();
                
                switch (choice)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        AddGrade();
                        break;
                    case "3":
                        AddNote();
                        break;
                    case "4":
                        GenerateReport();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Nevažeći odabir!");
                        break;
                }
            }
        }
        
        static void AddStudent()
        {
            Console.Write("Unesi ID učenika: ");
            var id = int.Parse(Console.ReadLine());
            Console.Write("Unesi ime: ");
            var firstName = Console.ReadLine();
            Console.Write("Unesi prezime: ");
            var lastName = Console.ReadLine();
            Console.Write("Unesi razred: ");
            var className = Console.ReadLine();
            
            students.Add(new Student(id, firstName, lastName, className));
            Console.WriteLine("Učenik uspješno dodan!");
        }
        
        static void AddGrade()
        {
            Console.Write("Unesi ID učenika: ");
            var studentId = int.Parse(Console.ReadLine());
            Console.Write("Unesi ocjenu (1-5): ");
            var value = int.Parse(Console.ReadLine());
            
            grades.Add(new Grade(studentId, value));
            Console.WriteLine("Ocjena uspješno upisana!");
        }
        
        static void AddNote()
        {
            Console.Write("Unesi ID učenika: ");
            var studentId = int.Parse(Console.ReadLine());
            Console.Write("Unesi napomenu: ");
            var content = Console.ReadLine();
            
            notes.Add(new Note(studentId, content));
            Console.WriteLine("Napomena uspješno dodana!");
        }
        
        static void GenerateReport()
        {
            Console.Write("Unesi ID učenika: ");
            var studentId = int.Parse(Console.ReadLine());
            
            var report = new Report(studentId);
            report.Grades = grades.FindAll(g => g.StudentId == studentId);
            report.Notes = notes.FindAll(n => n.StudentId == studentId);
            
            Console.WriteLine("\n" + report.Generate());
        }
    }
}
