using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Labs.Models
{
    public class Department
    {
        public int Id { get; set; }

        [MaxLength(25)]
        [MinLength(2)]
        public string DeptName { get; set; }

        public virtual ICollection<Student> Students { get; set; } 
        = new HashSet<Student>();
        public override string ToString()
        {
            return $"id: {Id}, Department Name: {DeptName}";
        }
    }
}
