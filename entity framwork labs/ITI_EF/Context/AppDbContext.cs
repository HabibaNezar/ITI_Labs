using ITI_EF.Models;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_EF.Context
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=ITI_EF;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stud_Course>()
                .HasKey(sc => new { sc.St_Id, sc.Crs_Id });

            modelBuilder.Entity<Ins_Course>()
                .HasKey(ic => new { ic.Ins_Id, ic.Crs_Id });

            modelBuilder.Entity<Student>()
                .HasOne(s => s.Supervisor)
                .WithMany(s => s.Subordinates)
                .HasForeignKey(s => s.St_super)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Department>()
                .HasOne(d => d.Manager)
                .WithMany()
                .HasForeignKey(d => d.Dept_Manager)
                .OnDelete(DeleteBehavior.NoAction);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Ins_Course> Ins_Courses { get; set; }
    }
}
