using Microsoft.EntityFrameworkCore;
using student.Domain.Entities;

namespace student.Infrastructure.Data
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        
        // public DbSet<Course> Courses { get; set; }
        // public DbSet<Enrollment> Enrollments { get; set; }
    }
}
