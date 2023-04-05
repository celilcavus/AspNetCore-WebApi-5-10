using CelilCavus.StudentCourseApi.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CelilCavus.StudentCourseApi.Data.Configuration
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(40);

            builder.Property(x => x.LastName).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(40);

            builder.HasMany(x=>x.Student).WithOne(x=>x.Teachers).HasForeignKey(x=>x.TeacherId);
        }
    }
}