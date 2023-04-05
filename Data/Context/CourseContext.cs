using CelilCavus.StudentCourseApi.Data.Configuration;
using CelilCavus.StudentCourseApi.Data.Entites;
using Microsoft.EntityFrameworkCore;

namespace CelilCavus.StudentCourseApi.Data.Context
{
    public class CourseContext : DbContext
    {
        public CourseContext(DbContextOptions<CourseContext> options) : base(options)
        {

        }
    
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new StudentCourseConfiguration());
            modelBuilder.ApplyConfiguration(new TeacherConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}