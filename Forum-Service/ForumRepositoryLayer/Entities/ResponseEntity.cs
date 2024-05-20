using System.Reflection.Metadata;

namespace ForumRepositoryLayer.Entities
{
    public class ResponseEntity
    {
        public string Id { get; set; }
        public int AutherId { get; set; }
        public string Text { get; set; }
        public string Content { get; set; }
        public PostEntity Post { get; set; }
        public ResponseEntity Response { get; set; }
        public DateTime DateTime { get; set; }

        public List<Blob> Attachements { get; set; }
        public int Likes { get; set; }

    }
}
