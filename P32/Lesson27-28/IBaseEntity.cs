namespace P32.Lesson27_28
{
    public interface IBaseEntity<T>
    {
        void Delete(T entity);
        void Save(T entity);
        void Update(T entity);
        T GetById(int id);
        
    }
}