using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITI_EF.Models
{
    internal class Department
    {
        [Key]
        public int Dept_Id { get; set; }
        public string Dept_Name { get; set; }
        public string Dept_Desc { get; set; }
        public string Dept_Location { get; set; }

        public int? Dept_Manager { get; set; }

        public DateTime? Manager_hiredate { get; set; }

        /*--------------------------------------------------*/
        // Relations
        /*--------------------------------------------------*/
        [ForeignKey("Dept_Manager")]
        public Instructor Manager { get; set; }

        [InverseProperty("Department")]
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();

        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
    }
}
