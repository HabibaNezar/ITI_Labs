using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5_c_
{
    public class Subject
    {
        public string SubjectName { get; set; }
        public List<Student> EnrolledStudents { get; set; } = new List<Student>();
        public Subject(string name) => SubjectName = name;
    }
}
