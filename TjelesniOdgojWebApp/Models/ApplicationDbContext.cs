using Microsoft.EntityFrameworkCore;
using TjelesniOdgojWebApp.Models;

namespace TjelesniOdgojWebApp
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Report> Reports { get; set; }
        
        // New entities will be added here
    }
}
