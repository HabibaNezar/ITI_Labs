using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Labs.Models
{
    public class Student
    {
        public int Id { get; set; }

        [MaxLength(20)]
        [MinLength(3)]
        public string Name { get; set; }
        public int Age {  get; set; }
        public decimal Salary { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        
        //navigation property
        public Department? Department { get; set; }
        public override string ToString()
        {
            return $"Id: [{Id}] Name: {Name} Age: {Age} Salary: {Salary} DepartmentId: {DepartmentId} Department: ---> {Department} <---";
        }
    }

     
}
