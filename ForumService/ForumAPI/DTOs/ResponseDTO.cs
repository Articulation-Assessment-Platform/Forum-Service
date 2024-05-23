using ForumRepositoryLayer.Entities;
using System.Reflection.Metadata;

namespace ForumAPI.DTOs
{
    public class ResponseDTO
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string Content { get; set; }
        public int PostId { get; set; }
        public int ResponseId { get; set; }
        public string Audience { get; set; }
        public DateTime DateTime { get; set; }  
        public string Url { get; set; }
        public int Likes { get; set; }
    }
}
