using ForumServiceLayer.Models;

namespace ForumServiceLayer.Services.Interfaces
{
    public interface IforumService
    {
        Task<List<ForumModel>> GetForums(string privacy);
    }
}
