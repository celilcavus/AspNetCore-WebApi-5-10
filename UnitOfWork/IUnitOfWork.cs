using CelilCavus.StudentCourseApi.Data.Interfaces;

namespace CelilCavus.UnitOfWork
{
    public interface IUnitOfWork
    {
        IRepository<T> GetRepository<T>() where T : class,new();
        void SaveChanges();
    }
}