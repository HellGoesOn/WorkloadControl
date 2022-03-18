using Microsoft.EntityFrameworkCore;
using WorkloadControl.Models;

namespace WorkloadControl.Context
{
    public class MainContext : DbContext
    {
        public DbSet<Group> Group {get; set;}
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<TeacherSubject> TeacherSubject { get; set; }

        public MainContext(DbContextOptions<MainContext> options) : base(options) { }
    }
}
