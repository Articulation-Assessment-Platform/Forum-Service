using Microsoft.EntityFrameworkCore;

namespace ForumRepositoryLayer.Entities
{
    public class ForumContext : DbContext
    {
        public ForumContext(DbContextOptions<ForumContext> options) : base(options)
        { }

        public DbSet<ForumEntity> Forums { get; set; }
        public DbSet<PostEntity> Children { get; set; }
        public DbSet<ResponseEntity> Responses { get; set; }

    }
}
