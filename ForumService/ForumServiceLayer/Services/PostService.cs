using ForumRepositoryLayer.Entities;
using ForumRepositoryLayer.Services.Interfaces;
using ForumServiceLayer.Models;
using ForumServiceLayer.Services.Interfaces;

namespace ForumServiceLayer.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;

        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<PostModel> Create(PostModel post)
        {
            PostEntity postEntity = new PostEntity()
            {
                Title = post.Title,
                Content = post.Content,
                AuthorId = post.AuthorId,
                DateTime = post.DateTime,
                Audience = post.Audience,
                Url = post.Url,
                ForumId = post.ForumId
            };

            PostEntity createdPostEntity = await _postRepository.AddAsync(postEntity);
            return TransformBack(createdPostEntity);
        }

        public async Task Update(PostModel post)
        {
            PostEntity existingPost = await _postRepository.GetByIdAsync(post.Id);
            if (existingPost != null)
            {
                existingPost.Title = post.Title;
                existingPost.Content = post.Content;
                existingPost.DateTime = post.DateTime;
                existingPost.Audience = post.Audience;

                _postRepository.Update(existingPost);
            }
            else
            {
                throw new ArgumentException("There is no post found to update.");
            }
        }

        public async Task Delete(PostModel post)
        {
            PostEntity existingPost = await _postRepository.GetByIdAsync(post.Id);
            if (existingPost != null)
            {
                _postRepository.Remove(existingPost);
            }
            else
            {
                throw new ArgumentException("There is no post with this information.");
            }
        }

        public async Task<PostModel> Get(int id)
        {
            PostEntity postEntity = await _postRepository.GetByIdAsync(id);
            return TransformBack(postEntity);
        }

        private PostModel TransformBack(PostEntity postEntity)
        {
            return new PostModel()
            {
                Id = postEntity.Id,
                Title = postEntity.Title,
                Content = postEntity.Content,
                AuthorId = postEntity.AuthorId,
                Audience = postEntity.Audience,
                DateTime = postEntity.DateTime,
                ForumId = postEntity.ForumId
            };
        }

        public async Task<List<PostModel>> GetAll(int forumId)
        {
            List<PostEntity> posts = await _postRepository.GetByForumId(forumId);

            List<PostModel> postModels = new List<PostModel>();
            foreach (PostEntity post in posts)
            {
                postModels.Add(new PostModel() { Id = post.Id, Title = post.Title, Audience = post.Audience, Content = post.Content, AuthorId = post.AuthorId, DateTime = post.DateTime, ForumId = post.ForumId, Url = post.Url });
            }

            return postModels;
        }
    }
}
