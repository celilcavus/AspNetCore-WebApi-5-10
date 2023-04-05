using CelilCavus.StudentCourseApi.Data.Interfaces;
using CelilCavus.StudentCourseApi.Data.Repository;
using Microsoft.EntityFrameworkCore;

namespace CelilCavus.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;

        public UnitOfWork(DbContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T : class, new()
        {
            return new Repository<T>(_context);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }

}