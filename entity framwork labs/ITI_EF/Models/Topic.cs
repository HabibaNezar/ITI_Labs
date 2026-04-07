using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_EF.Models
{
    internal class Topic
    {
        [Key]
        public int Top_Id { get; set; }
        public string Topic_Name { get; set; }
        /*--------------------------------------------------*/
        // relation
        /*--------------------------------------------------*/
        public ICollection <Course> Courses { get; set; }
        = new HashSet<Course>();
    }
}
