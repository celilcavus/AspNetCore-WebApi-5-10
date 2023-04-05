using CelilCavus.StudentCourseApi.Data.Context;
using CelilCavus.StudentCourseApi.Data.Interfaces;
using CelilCavus.StudentCourseApi.Data.Repository;
using CelilCavus.UnitOfWork;
using Microsoft.EntityFrameworkCore;
internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        // builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        // builder.Services.AddScoped<IRepository<Course>,CourseService>();
        builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
        builder.Services.AddScoped<DbContext, CourseContext>();
        builder.Services.AddDbContext<CourseContext>(x =>
        {
            x.UseSqlServer("Server=.;Database=AspEFCoreWebApi_StudentCourse;Trusted_Connection=True;TrustServerCertificate=True;");
        });

        var app = builder.Build();



        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}