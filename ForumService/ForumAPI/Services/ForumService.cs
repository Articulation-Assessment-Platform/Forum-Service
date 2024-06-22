﻿using ForumAPI.Entities;
using ForumAPI.Services.Interfaces;
using ForumAPI.Models;
using ForumAPI.Services.Interfaces;

namespace ForumAPI.Services
{
    public class ForumService : IforumService
    {
        private readonly IForumRepository _forumRepository;

        public ForumService(IForumRepository forumRepository)
        {
            _forumRepository = forumRepository;
        }

        public async Task<List<ForumModel>> GetForums(string privacy)
        {
            List<ForumEntity> f = await _forumRepository.GetAllForums(privacy);

            List<ForumModel> forums = new List<ForumModel>();

            foreach(ForumEntity entity in f)
            {
                forums.Add( new ForumModel()
                {
                    Id = entity.Id,
                    CategoryName = entity.CategoryName,
                    Description = entity.Description,
                    Audience = entity.Audience,
                });
            }
            return forums;
        }
    }
}
