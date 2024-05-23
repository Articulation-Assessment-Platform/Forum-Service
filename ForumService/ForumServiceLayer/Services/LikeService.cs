using ForumRepositoryLayer.Entities;
using ForumRepositoryLayer.Repositories.Interfaces;
using ForumServiceLayer.Models;
using ForumServiceLayer.Services.Interfaces;

namespace ForumServiceLayer.Services
{
    public class LikeService : ILikeService
    {
        private readonly ILikeRepository _likeRepository;

        public LikeService(ILikeRepository likeRepository)
        {
            _likeRepository = likeRepository;
        }

        public async Task<LikeModel> Create(LikeModel like)
        {
            LikeEntity likeEntity = new LikeEntity()
            {
                PostId = like.PostId,
                ResponseId = like.ResponseId,
                UserId = like.UserId
            };
            LikeEntity l = await _likeRepository.AddAsync(likeEntity);

            return new LikeModel()
            {
                Id = l.Id,
                PostId = l.PostId,
                ResponseId = l.ResponseId,
                UserId = l.UserId
            };
        }
        public void Delete(LikeModel like)
        {
            LikeEntity likeEntity = new LikeEntity()
            {
                Id = like.Id,
                PostId = like.PostId,
                ResponseId = like.ResponseId,
                UserId = like.UserId
            };
            _likeRepository.Remove(likeEntity);
        }

        public async Task<List<LikeModel>> GetAllPost(int postId)
        {
            List<LikeEntity> likes =  await _likeRepository.GetAllLikesPost(postId);

            List<LikeModel> likemodels = new List<LikeModel>();
            foreach(var likeEntity in likes)
            {
                likemodels.Add(new LikeModel() { Id= likeEntity.Id, PostId = likeEntity.PostId, UserId = likeEntity.UserId });
            }
            return likemodels;
        }
        public async Task<List<LikeModel>> GetAllResponse(int responseId)
        {
            List<LikeEntity> likes = await _likeRepository.GetAllLikesPost(responseId);

            List<LikeModel> likemodels = new List<LikeModel>();
            foreach (var likeEntity in likes)
            {
                likemodels.Add(new LikeModel() { Id = likeEntity.Id, ResponseId = likeEntity.ResponseId, UserId = likeEntity.UserId });
            }
            return likemodels;
        }
        public async Task<List<LikeModel>> GetAllUser(int userId)
        {
            List<LikeEntity> likes = await _likeRepository.GetAllLikesPost(userId);

            List<LikeModel> likemodels = new List<LikeModel>();
            foreach (var likeEntity in likes)
            {
                likemodels.Add(new LikeModel() { Id = likeEntity.Id, ResponseId = likeEntity.ResponseId, PostId = likeEntity.PostId, UserId = likeEntity.UserId });
            }
            return likemodels;
        }
    }
}
