using ForumRepositoryLayer.Entities;
using ForumRepositoryLayer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ForumRepositoryLayer.Repositories
{
    public class LikeRepository : BaseRepository<LikeEntity>, ILikeRepository
    {
        private readonly ForumContext _context;
        public LikeRepository(ForumContext context) : base(context)
        {
            _context = context;
        }

        public Task<List<LikeEntity>> GetAllLikesPost(int postId)
        {
            return _context.Likes
                .Where(l => l.PostId == postId)
                .ToListAsync();
        }

        public Task<List<LikeEntity>> GetAllLikesResponse(int responseId)
        {
            return _context.Likes
                .Where(l => l.ResponseId == responseId)
                .ToListAsync();
        }

        public Task<List<LikeEntity>> GetAllLikesUser(int userId)
        {
            return _context.Likes
                .Where(l => l.UserId == userId)
                .ToListAsync();
        }
    }
}
