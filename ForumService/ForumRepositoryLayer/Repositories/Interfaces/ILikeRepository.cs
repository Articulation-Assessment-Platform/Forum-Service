using ForumRepositoryLayer.Entities;
using ForumRepositoryLayer.Services.Interfaces;

namespace ForumRepositoryLayer.Repositories.Interfaces
{
    public interface ILikeRepository : IBaseRepository<LikeEntity>
    {
        Task<List<LikeEntity>> GetAllLikesPost(int postId);
        Task<List<LikeEntity>> GetAllLikesResponse(int responseId);
        Task<List<LikeEntity>> GetAllLikesUser(int userId);
    }
}
