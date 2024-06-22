namespace RepositoryLayer.Repositories
{
    using System.Threading.Tasks;
    using RepositoryLayer.Entities;
    using RepositoryLayer.Services.Interfaces;
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

        public void Remove(int id)
        {
            // Retrieve the entity by its ID
            var entity = _context.Set<TEntity>().Find(id);

            // Check if the entity exists
            if (entity != null)
            {
                // Remove the entity
                _context.Set<TEntity>().Remove(entity);

                // Save changes to the database
                _context.SaveChanges();
            }
        }
    }

}
