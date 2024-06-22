using ServiceLayer.Models;

namespace ServiceLayer.Services.Interfaces
{
    public interface ILikeService
    {
        Task<LikeModel> Create(LikeModel like);
        void Delete(LikeModel like);
        Task<List<LikeModel>> GetAllPost(int postId);
        Task<List<LikeModel>> GetAllResponse(int responseId);
        Task<List<LikeModel>> GetAllUser(int userId);
    }
}
