using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Project1.Models
{
    public class Student
    {
        [Key]
        public int Ssn { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string? Image { get; set; }

        // realtion with deparment
        public int? DeptId { get; set; }
        [ForeignKey("DeptId")]
        public Department? Dept { get; set; }
        // relation with course
        public ICollection<StudentCourse>? StudentCourses { get; set; }
    }
}
