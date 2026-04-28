using MVC_Project1.Models;

namespace MVC_Project1.Repository
{
    public interface IStudentRepository : IRepository<Student>
    {
        List<StudentCourse> GetStudentCourses(int ssn);
    }
}
