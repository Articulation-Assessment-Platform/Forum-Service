﻿using RepositoryLayer.Entities;

namespace RepositoryLayer.Services.Interfaces
{
    public interface IPostRepository : IBaseRepository<PostEntity>
    {
        Task<List<PostEntity>> GetByForumId(int ForumId);

        Task<List<PostEntity>> GetByUserId(int userId);
    }
}
