using ForumAPI.Entities;

namespace ForumAPI.Services.Interfaces
{
    public interface IForumRepository : IBaseRepository<ForumEntity>
    {
        Task<List<ForumEntity>> GetAllForums(string audience);
    }
}
