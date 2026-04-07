using System.ComponentModel.DataAnnotations;

namespace MVC_Day1.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; } 
        public string SSN { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Image { get; set; } 
    }
}
