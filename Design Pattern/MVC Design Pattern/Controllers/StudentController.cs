using MVC_Design_Pattern.Models;
using MVC_Design_Pattern.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Design_Pattern.Controllers
{
    internal class StudentController
    {
        private List<Student> students = new List<Student>();
        private StudentView view = new StudentView();

        // Index() – Display all students
        public void Index()
        {
            view.ShowStudents(students);
        }

        // Details(int id)
        public void Details(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student != null)
                view.ShowStudentDetails(student);
            else
                view.ShowMessage("Student not found");
        }

        // Create() GET
        public void Create()
        {
            Student student = view.GetNewStudent();
            Create(student);
        }

        // Create(Student student) POST
        public void Create(Student student)
        {
            students.Add(student);
            view.ShowMessage("Student added successfully");
        }
    }
}
