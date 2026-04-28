namespace MVC_Project1.Models
{
    public class StudentCourse
    {
        public int Ssn { get; set; }              // PK + FK
        public int CrsId { get; set; }            // PK + FK
        public string Grade { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
