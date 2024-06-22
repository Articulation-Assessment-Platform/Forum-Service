using ForumAPI.Models;

namespace ForumAPI.Services.Interfaces
{
    public interface IforumService
    {
        Task<List<ForumModel>> GetForums(string privacy);
    }
}
