using MVC_Project1.Context;
using MVC_Project1.Models;

namespace MVC_Project1.Repository
{
    public class DepartmentRepository: IDepartmentRepository
    {
        private readonly DbAppContext db;

        public DepartmentRepository(DbAppContext context)
        {
            this.db = context;
        }

        public void add(Department entity)
        {
            db.Departments.Add(entity);
        }

        public void delete(int id)
        {
            var dept = db.Departments.FirstOrDefault(d => d.DeptId == id);
            if (dept != null)
            {
                db.Departments.Remove(dept);
            }
        }

        public List<Department> GetAll(string includeProperties = "")
        {
            return db.Departments.ToList();
        }

        public Department GetById(int id, string includeProperties = "")
        {
            return db.Departments.FirstOrDefault(d => d.DeptId == id);
        }

        public void save()
        {
            db.SaveChanges();
        }

        public void update(Department entity)
        {
            db.Departments.Update(entity);
        
        }
    }
}
