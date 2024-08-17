using EF_Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace EF_Core.Context
{
    internal class ITIDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=myDb;trusted_connection=true;Encrypt=False");
        }
        public DbSet<Course> Course { get; set; }
        public DbSet<Course_Inst> Course_Inst { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Instructor>Instructor {  get; set; }
        public DbSet<Stud_course> Stud_Course { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Topic> Topic { get; set; }
        

    }
}
