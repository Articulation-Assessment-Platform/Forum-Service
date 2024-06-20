namespace ForumRepositoryLayer.Services.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetByIdAsync(int id);
        Task<TEntity> AddAsync(TEntity entity);
        void Update(TEntity entity);
        void Remove(int id);
    }
}
