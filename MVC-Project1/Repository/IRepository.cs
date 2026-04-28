namespace MVC_Project1.Repository
{
    public interface IRepository<T>
    {
        List<T> GetAll(string includeProperties = "");
        T GetById(int id, string includeProperties = "");
        void add(T entity);
        void update(T entity);
        void delete(int id);
        void save(); // to save changes to the database
    }
}
