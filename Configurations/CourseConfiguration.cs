using EF_Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Core01.Configurations
{
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> course)
        {
            course.Property("Name").IsRequired(true).HasMaxLength(50);
            course.Property(c=>c.ID).UseIdentityColumn(3,30);
        }
    }
}
