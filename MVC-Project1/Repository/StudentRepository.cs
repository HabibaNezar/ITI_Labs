using MVC_Project1.Context;
using MVC_Project1.Models;
using Microsoft.EntityFrameworkCore;


namespace MVC_Project1.Repository
{
    public class StudentRepository: IStudentRepository
    {
        // crud operations for student
        private readonly DbAppContext db;

        public StudentRepository(DbAppContext context)
        {
            this.db = context;
        }

        public List<Student> GetAll(string includeProperties = "")
        {
            return db.Students.Include(includeProperties).ToList();
        }

        public Student GetById(int id, string includeProperties = "")
        {
            var query = db.Students.AsQueryable();

            // ✅ only call Include if a property name was actually provided
            if (!string.IsNullOrEmpty(includeProperties))
            {
                query = query.Include(includeProperties);
            }

            return query.FirstOrDefault(s => s.Ssn == id);
        }

        public void add(Student entity)
        {
            db.Students.Add(entity);
        }

        public void update(Student entity)
        {
            db.Students.Update(entity);
        }

        public void delete(int id)
        {
            var student = db.Students.FirstOrDefault(s => s.Ssn == id);
            if (student != null)
            {
                db.Students.Remove(student);
            }
        }

        public void save()
        {
            db.SaveChanges();
        }

        public List<StudentCourse> GetStudentCourses(int ssn)
        {
            return db.StudentCourses
                     .Include(c => c.Course)
                     .Where(sc => sc.Ssn == ssn)
                     .ToList();
        }
    }
}
