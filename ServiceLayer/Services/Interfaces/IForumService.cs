using ServiceLayer.Models;

namespace ServiceLayer.Services.Interfaces
{
    public interface IforumService
    {
        Task<List<ForumModel>> GetForums(string privacy);
    }
}
