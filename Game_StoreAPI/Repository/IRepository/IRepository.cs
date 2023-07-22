namespace Game_StoreAPI.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll(string? includeproperties = null);
        T Get(bool tracked=true, string? includeproperties = null);
        void Create(T entity);
        void Remove(T entity);
        void Save();
    }
}
