using System.Reflection.Metadata;

namespace ForumServiceLayer.Models
{
    public class ResponseModel
    {
        public string Id { get; set; }
        public int AutherId { get; set; }
        public string Text { get; set; }
        public string Content { get; set; }
        public PostModel Post { get; set; }
        public ResponseModel Response { get; set; }
        public DateTime DateTime { get; set; }

        public List<Blob> Attachements { get; set; }
        public int Likes { get; set; }
        
    }
}
