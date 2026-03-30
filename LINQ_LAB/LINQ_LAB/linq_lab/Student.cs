using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_lab
{
    internal class Student
    {
        // prop
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public int TrackId { get; set; }
        public Subject[] Subject { get; set; }

        // constructor
        public Student() { }
        public Student(int id, string firstname, string lastname, int age, decimal salary, int trackid)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            Salary = salary;
            TrackId = trackid;
        }
        public Student(int id, string firstname, string lastname, Subject[] subject)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Subject = subject;
        }

        // override method
        public override string ToString()
        {
            return $"[{Id}] {FirstName} {LastName} Age: {Age} | Salary: {Salary} | TrackId: {TrackId}";
        }
    }
}
