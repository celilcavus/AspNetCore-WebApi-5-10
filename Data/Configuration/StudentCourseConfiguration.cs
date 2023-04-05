using CelilCavus.StudentCourseApi.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CelilCavus.StudentCourseApi.Data.Configuration
{
    public class StudentCourseConfiguration : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.Property(x=>x.Id).UseIdentityColumn();

            // builder.HasMany(x=>x.courses).WithMany(x=>x.Id);
        }
    }
}