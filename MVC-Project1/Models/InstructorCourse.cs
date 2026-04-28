namespace MVC_Project1.Models
{
    public class InstructorCourse
    {
        public int InsId { get; set; }            // PK + FK
        public int CrsId { get; set; }            // PK + FK
        public int Hours { get; set; }

        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
    }
}
