using MVC_Design_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Design_Pattern.Views
{
    internal class StudentView
    {
        public void ShowStudents(List<Student> students)
        {
            Console.WriteLine("Students List:");

            foreach (var s in students)
            {
                Console.WriteLine($"ID: {s.Id} | Name: {s.Name} | Grade: {s.Grade} | Email: {s.Email}");
            }
        }

        public void ShowStudentDetails(Student student)
        {
            Console.WriteLine("Student Details:");
            Console.WriteLine($"ID: {student.Id}");
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Grade: {student.Grade}");
            Console.WriteLine($"Email: {student.Email}");
        }

        public Student GetNewStudent()
        {
            Student s = new Student();

            Console.Write("Enter Id: ");
            s.Id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            s.Name = Console.ReadLine();

            Console.Write("Enter Grade: ");
            s.Grade = double.Parse(Console.ReadLine());

            Console.Write("Enter Email: ");
            s.Email = Console.ReadLine();

            return s;
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
