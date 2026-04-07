using Microsoft.EntityFrameworkCore;
using MVC_Day1.Models;

namespace MVC_Day1.Context
{
    public class DbAbbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=MVC_Day1;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        public DbSet<Student> Students { get; set; }
    }
}
