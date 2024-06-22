using Microsoft.EntityFrameworkCore;

namespace RepositoryLayer.Entities
{
    public class ForumContext : DbContext
    {
        public ForumContext(DbContextOptions<ForumContext> options) : base(options)
        { }

        public DbSet<ForumEntity> Forums { get; set; }
        public DbSet<PostEntity> Posts { get; set; }
        public DbSet<ResponseEntity> Responses { get; set; }
        public DbSet<LikeEntity> Likes { get; set; }

    }
}
