
using System.ComponentModel.DataAnnotations;

namespace day2.Models
{
    internal class Topic
    {
        [Key]
        public int Top_Id { get; set; }
        public string Topic_Name { get; set; }
        /*--------------------------------------------------*/
        // relation
        /*--------------------------------------------------*/
        public ICollection<Course> Courses { get; set; }
        = new HashSet<Course>;
    }
}
