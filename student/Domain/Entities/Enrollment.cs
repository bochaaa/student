namespace student.Domain.Entities
{
    public class Enrollment
    {
        public int Id { get; set; }
        public Student StudentId { get; set; }
        public Course CourseId { get; set; }
        public DateOnly EnrollmentDate { get; set; }
    }
}
