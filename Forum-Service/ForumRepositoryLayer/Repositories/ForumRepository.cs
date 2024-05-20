using ForumRepositoryLayer.Entities;
using ForumServiceLayer.Models;
using ForumServiceLayer.Services.Interfaces;

namespace ForumRepositoryLayer.Repositories
{
    public class ForumRepository : IBaseRepository<ForumModel>, IForumRepository
    {
        public Task<ForumModel> AddAsync(ForumModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<ForumModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(ForumModel entity)
        {
            throw new NotImplementedException();
        }

        public void Update(ForumModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
