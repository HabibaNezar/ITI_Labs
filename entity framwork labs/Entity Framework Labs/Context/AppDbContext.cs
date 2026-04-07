using Entity_Framework_Labs.Models;
using Microsoft.EntityFrameworkCore;


namespace Entity_Framework_Labs.Context
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Entity_lab;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            optionsBuilder.UseSqlServer(connectionString);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            
            base.OnModelCreating(modelBuilder);

        }
        // confiqure Models That Map to db tables
        // local container that represent db tables
        public  DbSet<Student> Students { get; set; }
        public  DbSet<Department> Departments { get; set; }


    }
}
