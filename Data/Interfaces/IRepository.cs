namespace CelilCavus.StudentCourseApi.Data.Interfaces
{
    public interface IRepository<T> where T : class,new()
    {
        void Add(T item);
        void Update(T item);
        void Delete(T item);
        
        T GetById(int id);

        ICollection<T> GetList();

    }
}