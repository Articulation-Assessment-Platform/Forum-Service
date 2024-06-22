using RepositoryLayer.Entities;
using ServiceLayer.Models;

namespace ForumAPI.Dtos
{
    public class ForumDto
    {
        public int Id { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Audience { get; set; } = string.Empty;


    }
}
