using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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
            if (like == null)
            {
                throw new ArgumentNullException(nameof(like), "LikeModel cannot be null.");
            }

            LikeEntity likeEntity = new LikeEntity()
            {
                PostId = like.PostId,
                ResponseId = like.ResponseId,
                UserId = like.UserId
            };
            LikeEntity createdLikeEntity = await _likeRepository.AddAsync(likeEntity);

            return new LikeModel()
            {
                Id = createdLikeEntity.Id,
                PostId = createdLikeEntity.PostId,
                ResponseId = createdLikeEntity.ResponseId,
                UserId = createdLikeEntity.UserId
            };
        }

        public void Delete(LikeModel like)
        {
            if (like == null)
            {
                throw new ArgumentNullException(nameof(like), "LikeModel cannot be null.");
            }

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
            if (postId <= 0)
            {
                throw new ArgumentException("Invalid postId.");
            }

            List<LikeEntity> likes = await _likeRepository.GetAllLikesPost(postId);

            List<LikeModel> likeModels = new List<LikeModel>();
            foreach (var likeEntity in likes)
            {
                likeModels.Add(new LikeModel()
                {
                    Id = likeEntity.Id,
                    PostId = likeEntity.PostId,
                    ResponseId = likeEntity.ResponseId,
                    UserId = likeEntity.UserId
                });
            }
            return likeModels;
        }

        public async Task<List<LikeModel>> GetAllResponse(int responseId)
        {
            if (responseId <= 0)
            {
                throw new ArgumentException("Invalid responseId.");
            }

            List<LikeEntity> likes = await _likeRepository.GetAllLikesResponse(responseId);

            List<LikeModel> likeModels = new List<LikeModel>();
            foreach (var likeEntity in likes)
            {
                likeModels.Add(new LikeModel()
                {
                    Id = likeEntity.Id,
                    PostId = likeEntity.PostId,
                    ResponseId = likeEntity.ResponseId,
                    UserId = likeEntity.UserId
                });
            }
            return likeModels;
        }

        public async Task<List<LikeModel>> GetAllUser(int userId)
        {
            if (userId <= 0)
            {
                throw new ArgumentException("Invalid userId.");
            }

            List<LikeEntity> likes = await _likeRepository.GetAllLikesUser(userId);

            List<LikeModel> likeModels = new List<LikeModel>();
            foreach (var likeEntity in likes)
            {
                likeModels.Add(new LikeModel()
                {
                    Id = likeEntity.Id,
                    PostId = likeEntity.PostId,
                    ResponseId = likeEntity.ResponseId,
                    UserId = likeEntity.UserId
                });
            }
            return likeModels;
        }
    }
}
