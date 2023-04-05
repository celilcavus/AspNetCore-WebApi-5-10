using CelilCavus.StudentCourseApi.Data.Context;
using CelilCavus.StudentCourseApi.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CelilCavus.StudentCourseApi.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly DbContext _context;


        public Repository(DbContext context)
        {
            _context = context;

        }

        public void Add(T item)
        {
            _context.Set<T>().Add(item);
        }

        public void Delete(T item)
        {
            _context.Set<T>().Remove(item);
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public ICollection<T> GetList()
        {
            return _context.Set<T>().AsNoTracking().ToList();
        }

        public void Update(T item)
        {
            _context.Set<T>().Update(item);
        }
    }
}