namespace backend.Repositories
{
    public interface IRepository<T>
        where T : class, new()
    {
        Task Add(T entity);
        Task Delete(T entity);
        Task Edit(T entity);
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAll();
    }
}
