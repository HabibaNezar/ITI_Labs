using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ITI_EF.Models
{
    internal class Course
    {
        [Key]
        public int Crs_Id { get; set; }
        public string Crs_Name { get; set; }
        public int Crs_Duration { get; set; }

        /*--------------------------------------------------*/
        // Relations
        /*--------------------------------------------------*/
        [ForeignKey("Topic")]
        public int? Top_Id { get; set; }
        public Topic Topic { get; set; }

        public ICollection<Stud_Course> Stud_Courses { get; set; } = new HashSet<Stud_Course>();

        public ICollection<Ins_Course> Ins_Courses { get; set; } = new HashSet<Ins_Course>();
    }
}
