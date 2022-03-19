using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

public class SandboxContext : DbContext
{
    public SandboxContext(DbContextOptions<SandboxContext> options)
            : base(options)
    {
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }
    public DbSet<Course> Courses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}

public class Student
{
    public int ID { get; set; }
    public string LastName { get; set; } = "";
    public string FirstMidName { get; set; } = "";
    public DateTime EnrollmentDate { get; set; }

    public virtual ICollection<Enrollment>? Enrollments { get; set; }
}

public enum Grade
{
    A, B, C, D, F
}

public class Enrollment
{
    public int EnrollmentID { get; set; }
    public int CourseID { get; set; }
    public int StudentID { get; set; }
    public Grade? Grade { get; set; }

    public virtual Course? Course { get; set; }
    public virtual Student? Student { get; set; }
}

public class Course
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int CourseID { get; set; }
    public string Title { get; set; } = "";
    public int Credits { get; set; }

    public virtual ICollection<Enrollment>? Enrollments { get; set; }
}
