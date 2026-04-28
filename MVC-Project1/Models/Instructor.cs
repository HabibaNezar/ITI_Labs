using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Project1.Models
{
    public class Instructor
    {
        [Key]
        public int InsId { get; set; }
        public string InsName { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public string Degree { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public int DeptId { get; set; }           // FK
        [ForeignKey("DeptId")]
        public Department Dept { get; set; }      // navigation

        public ICollection<InstructorCourse> InstructorCourses { get; set; }
    }
}
