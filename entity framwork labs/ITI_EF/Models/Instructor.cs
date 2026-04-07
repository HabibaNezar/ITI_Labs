using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_EF.Models
{
    internal class Instructor
    {
        [Key]
        public int Ins_Id { get; set; }
        public string Ins_Name { get; set; }
        public string Ins_Degree { get; set; }
        public decimal Salary { get; set; }

        /*--------------------------------------------------*/
        // Relations
        /*--------------------------------------------------*/
        [ForeignKey("Department")]
        public int? Dept_Id { get; set; }
        public Department Department { get; set; }

        public ICollection<Ins_Course> Ins_Courses { get; set; } = new HashSet<Ins_Course>();
    }
}
