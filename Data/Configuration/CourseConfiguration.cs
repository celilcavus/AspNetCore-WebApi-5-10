using CelilCavus.StudentCourseApi.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CelilCavus.StudentCourseApi.Data.Configuration
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Id).UseIdentityColumn();

            builder.Property(x=>x.Description).HasMaxLength(400);
            builder.Property(x=>x.Description).IsRequired();

            builder.HasMany(x=>x.StudentCourses).WithOne(x=>x.courses).HasForeignKey(x=>x.CourseId);
        }
    }
}