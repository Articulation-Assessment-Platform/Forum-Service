using RepositoryLayer.Entities;
using RepositoryLayer.Services.Interfaces;

namespace RepositoryLayer.Repositories.Interfaces
{
    public interface ILikeRepository : IBaseRepository<LikeEntity>
    {
        Task<List<LikeEntity>> GetAllLikesPost(int postId);
        Task<List<LikeEntity>> GetAllLikesResponse(int responseId);
        Task<List<LikeEntity>> GetAllLikesUser(int userId);
    }
}
