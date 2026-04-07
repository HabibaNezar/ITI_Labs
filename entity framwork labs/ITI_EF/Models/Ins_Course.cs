using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_EF.Models
{
    internal class Ins_Course
    {
        [ForeignKey("Instructor")]
        public int Ins_Id { get; set; }
        public Instructor Instructor { get; set; }

        [ForeignKey("Course")]
        public int Crs_Id { get; set; }
        public Course Course { get; set; }

        public string Evaluation { get; set; }
    }
}
