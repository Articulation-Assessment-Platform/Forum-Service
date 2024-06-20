using ForumServiceLayer.Models;

namespace ForumServiceLayer.Services.Interfaces
{
    public interface IPostService
    {
        Task<PostModel> Create(PostModel post);
        Task Update(PostModel post);
        void Delete(int id);
        Task<PostModel> Get(int id);
        Task<List<PostModel>> GetAll(int forumId);
        Task<List<PostModel>> GetAllUser(int userId);

    }
}
