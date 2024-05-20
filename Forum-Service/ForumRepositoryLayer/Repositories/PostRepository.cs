using ForumServiceLayer.Models;
using ForumServiceLayer.Services.Interfaces;

namespace ForumRepositoryLayer.Repositories
{
    public class PostRepository : IBaseRepository<PostModel>, IPostRepository
    {
        public Task<PostModel> AddAsync(PostModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<PostModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(PostModel entity)
        {
            throw new NotImplementedException();
        }

        public void Update(PostModel entity)
        {
            throw new NotImplementedException();
        }
    }

}
