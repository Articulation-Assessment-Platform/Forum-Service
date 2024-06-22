using RepositoryLayer.Entities;
using RepositoryLayer.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace RepositoryLayer.Repositories
{
    public class ForumRepository : BaseRepository<ForumEntity>, IForumRepository
    {
        public ForumRepository(ForumContext context) : base(context)
        { 

        }

        public Task<List<ForumEntity>> GetAllForums(string audience)
        {
            return _context.Forums
                .Where(f => (audience == null && f.Audience == "None") ||
                            (audience == "SpeechTherapist" && (f.Audience == "SpeechTherapist" || f.Audience == "All")) ||
                            (audience == "Parent" && (f.Audience == "Parents" || f.Audience == "All")))
                .ToListAsync();
        }
    }
}
