using ForumRepositoryLayer.Entities;
using ForumServiceLayer.Models;
using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;

namespace ForumAPI.DTOs
{
    public class PostDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int AuthorId { get; set; }
        public string Audience { get; set; }
        public DateTime DateTime { get; set; }
        public int Likes { get; set; }
        public string Url { get; set; }
        public int ForumId { get; set; }
    }
}
