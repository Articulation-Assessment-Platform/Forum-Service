using ForumAPI.Entities;
using ForumAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ForumAPI.Repositories
{
    public class PostRepository : BaseRepository<PostEntity>, IPostRepository
    {
        private new readonly ForumContext _context;
        public PostRepository(ForumContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<PostEntity>> GetByForumId(int ForumId)
        {
            List<PostEntity> posts = await _context.Set<PostEntity>()
                .Where(e => e.ForumId == ForumId)
                .ToListAsync();

            return posts;
        }

        public async Task<List<PostEntity>> GetByUserId(int userId)
        {
            List<PostEntity> posts = await _context.Set<PostEntity>()
                .Where(e => e.AuthorId == userId)
                .ToListAsync();

            return posts;
        }
    }

}
