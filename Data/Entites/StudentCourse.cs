namespace CelilCavus.StudentCourseApi.Data.Entites
{
    public class StudentCourse
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Students { get; set; }
        public int CourseId { get; set; }
        public Course courses { get; set; }
    }
}