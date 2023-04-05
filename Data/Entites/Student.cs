namespace CelilCavus.StudentCourseApi.Data.Entites
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teachers { get; set; }

        public List<StudentCourse> StudentCourses { get; set; }
    }

  
}