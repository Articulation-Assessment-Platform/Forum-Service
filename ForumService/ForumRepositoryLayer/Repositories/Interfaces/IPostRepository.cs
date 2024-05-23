﻿using ForumRepositoryLayer.Entities;

namespace ForumRepositoryLayer.Services.Interfaces
{
    public interface IPostRepository : IBaseRepository<PostEntity>
    {
        Task<List<PostEntity>> GetByForumId(int ForumId);
    }
}