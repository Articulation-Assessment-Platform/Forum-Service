using RepositoryLayer.Entities;

namespace RepositoryLayer.Services.Interfaces
{
    public interface IForumRepository : IBaseRepository<ForumEntity>
    {
        Task<List<ForumEntity>> GetAllForums(string audience);
    }
}
