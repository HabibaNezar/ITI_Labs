using MVC_Project1.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Project1.ViewModels
{
    public class StudentViewModel
    {
        public int Ssn { get; set; }

        [MinLength(4, ErrorMessage ="Name must be more than 4 letters")]
        [MaxLength(15, ErrorMessage = "Name must be less than 15 letters")]
        //[Unique]
        public string Name { get; set; }
        
        [RegularExpression(@"\w+@gmail\.com", ErrorMessage ="Enter a valid email")]
        public string Email { get; set; }

        public string Phone { get; set; }
        public string Address { get; set; }
        
        [RegularExpression(@"^.*\.(jpg|png|JPG|PNG)$", ErrorMessage ="Image must be either png or jpg")]
        public string? Image { get; set; }
        public string? DeptName { get; set; }
        public int? DeptId { get; set; }
        public List<Department>? Departments { get; set; }
        public ICollection<StudentCourse>? StudentCourses { get; set; }

    }
}
