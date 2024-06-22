
using ForumRepositoryLayer.Entities;
using System.Reflection.Metadata;

namespace ForumRepositoryLayer.Entities
{
    public class PostEntity
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public required int AuthorId { get; set; }
        public required DateTime DateTime { get; set; }
        public string Audience { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public required int ForumId { get; set; }
    }
}
