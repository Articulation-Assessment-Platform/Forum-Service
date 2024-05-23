using ForumRepositoryLayer.Entities;
using ForumRepositoryLayer.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ForumRepositoryLayer.Repositories
{
    public class PostRepository : BaseRepository<PostEntity>, IPostRepository
    {
        private readonly ForumContext _context;
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
    }

}
