using ForumServiceLayer.Models.Enums;
using System.Reflection.Metadata;

namespace ForumServiceLayer.Models
{
    public class PostModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int AuthorId { get; set; }
        public Audience Privacy {  get; set; } 
        public DateTime DateTime { get; set; }
        public int Likes { get; set; }
        public List<Blob> Attachments { get; set; }
        public PostModel Post {  get; set; }
        public List<ResponseModel> Responses { get; set; }
    }
}
