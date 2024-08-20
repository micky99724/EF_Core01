using EF_Core.Entities;
using EF_Core01.Configurations;
using Microsoft.EntityFrameworkCore;

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
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<Stud_course> Stud_Course { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Topic> Topic { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new Course_InstConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfigration());
            modelBuilder.Entity<Stud_course>()
                        .HasKey(sc => new { sc.Stud_ID, sc.Course_ID });

            modelBuilder.Entity<Course_Inst>()
                        .HasKey(ci => new { ci.Course_ID, ci.Inst_ID });
        }
    }
}
