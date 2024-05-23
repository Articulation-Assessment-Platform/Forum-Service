using ForumRepositoryLayer.Entities;
using ForumServiceLayer.Models;

namespace ForumAPI.DTOs
{
    public class ForumDTO
    {
        public int Id { get; set; }
        public string CategoryName { get; set; } = null;
        public string Description { get; set; } = null;
        public string Audience { get; set; } = null;


    }
}
