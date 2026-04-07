using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_EF.Models
{
    internal class Student
    {
        [Key]
        public int St_Id { get; set; }
        [MinLength(3)]
        public string St_Fname { get; set; }
        
        public string St_Lname { get; set; }
        public string St_Address { get; set; }
        public int? St_Age { get; set; }

        /*--------------------------------------------------*/
        // Relations
        /*--------------------------------------------------*/
        [ForeignKey("Department")]
        public int? Dept_Id { get; set; }
        public Department Department { get; set; }

        [ForeignKey("Supervisor")]
        public int? St_super { get; set; }
        public Student Supervisor { get; set; }

        [InverseProperty("Supervisor")]
        public ICollection<Student> Subordinates { get; set; } = new HashSet<Student>();

        public ICollection<Stud_Course> Stud_Courses { get; set; } = new HashSet<Stud_Course>();
    }
}
