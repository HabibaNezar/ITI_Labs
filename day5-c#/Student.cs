using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5_c_
{
    public class Student
    {
        public string Name { get; set; }
        public Student(string name) => Name = name;

        public void NotifyExamStarted(string subjectName)
        {
            Console.WriteLine($"Notification for {Name}: The exam for {subjectName} is now starting!");
        }
    }
}
