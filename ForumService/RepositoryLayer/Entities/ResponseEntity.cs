using System.Reflection.Metadata;

namespace RepositoryLayer.Entities
{
    public class ResponseEntity
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string Content { get; set; } = string.Empty;
        public int PostId { get; set; }
        public int ResponseId { get; set; }
        public string Audience {  get; set; } = string.Empty;
        public DateTime DateTime { get; set; }
        public string Url { get; set; } = string.Empty;
        public int Likes { get; set; }

    }
}
