using System.Reflection.Metadata;

namespace ForumRepositoryLayer.Entities
{
    public class PostEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int AuthorId { get; set; }
        public Audience Privacy { get; set; }
        public DateTime DateTime { get; set; }
        public int Likes { get; set; }
        public List<Blob> Attachments { get; set; }
        public PostEntity Post { get; set; }
        public List<ResponseEntity> Responses { get; set; }
    }
}
