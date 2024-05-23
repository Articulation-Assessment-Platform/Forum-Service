
using ForumRepositoryLayer.Entities;
using System.Reflection.Metadata;

namespace ForumRepositoryLayer.Entities
{
    public class PostEntity
    {
        public int Id { get; set; }
        public string Title { get; set; } = null;
        public string Content { get; set; } = null;
        public int AuthorId { get; set; }
        public DateTime DateTime { get; set; }
        public string Audience { get; set; } = null;
        public string Url { get; set; } = null;
        public int ForumId { get; set; }
    }
}
