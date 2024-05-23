
using ForumRepositoryLayer.Entities;
using System.Reflection.Metadata;

namespace ForumRepositoryLayer.Entities
{
    public class PostEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int AuthorId { get; set; }
        public DateTime DateTime { get; set; }
        public string Audience { get; set; }
        public string Url { get; set; }
        public int ForumId { get; set; }
    }
}
