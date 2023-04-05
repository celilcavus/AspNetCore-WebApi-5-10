using CelilCavus.StudentCourseApi.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CelilCavus.StudentCourseApi.Data.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.FirstName).HasMaxLength(40);

            builder.Property(x => x.LastName).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(40);

            builder.Property(x => x.DateOfBirth).IsRequired();

            builder.HasMany(x=>x.StudentCourses).WithOne(x=>x.Students).HasForeignKey(x=>x.StudentId);
        }
    }
}