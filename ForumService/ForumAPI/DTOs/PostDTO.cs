using ForumRepositoryLayer.Entities;
using ForumServiceLayer.Models;
using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;

namespace ForumAPI.DTOs
{
    public class PostDTO
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public int AuthorId { get; set; }
        public string Audience { get; set; } = string.Empty;
        public DateTime DateTime { get; set; }
        public string Url { get; set; } = string.Empty;
        public int ForumId { get; set; }
    }
}
