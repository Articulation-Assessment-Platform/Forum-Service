namespace ForumRepositoryLayer.Repositories
{
    using System.Threading.Tasks;
    using ForumRepositoryLayer.Entities;
    using ForumRepositoryLayer.Services.Interfaces;
    using Microsoft.EntityFrameworkCore;

    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class 

    {
        protected readonly ForumContext _context;

        public BaseRepository(ForumContext context)
        {
            _context = context;
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }
    }

}
