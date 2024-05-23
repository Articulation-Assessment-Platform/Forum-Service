using ForumRepositoryLayer.Entities;

namespace ForumRepositoryLayer.Services.Interfaces
{
    public interface IForumRepository : IBaseRepository<ForumEntity>
    {
        Task<List<ForumEntity>> GetAllForums(string audience);
    }
}
