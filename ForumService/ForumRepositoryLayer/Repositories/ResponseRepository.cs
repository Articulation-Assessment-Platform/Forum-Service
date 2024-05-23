using ForumRepositoryLayer.Entities;
using ForumRepositoryLayer.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ForumRepositoryLayer.Repositories
{
    public class ResponseRepository : BaseRepository<ResponseEntity>, IResponseRepository
    {
        private readonly ForumContext _context;
        public ResponseRepository(ForumContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<ResponseEntity>> GetByPostId(int PostId)
        {
            List<ResponseEntity> responses = await _context.Set<ResponseEntity>()
                .Where(e => e.PostId == PostId)
                .ToListAsync();

            return responses;
        }
    }
}
