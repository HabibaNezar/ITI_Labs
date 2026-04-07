using ITI_EF_Day3.Services;

namespace EF_Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // student crud operation
            StudentService studentService = new StudentService();
            //--- create
            //studentService.CreateStudent("habiba", "nezar", "tanta", 23, 10, 1);
            //--- read
            //studentService.ReadAllStudents();
            //--- update
            //studentService.UpdateStudentAge(0, 20);
            //--- delete
            //studentService.DeleteStudent(0);

        }
    }
}
