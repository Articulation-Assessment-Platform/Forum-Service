using ForumRepositoryLayer.Entities;
using ForumServiceLayer.Models;

namespace ForumAPI.DTOs
{
    public class ForumDTO
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Audience { get; set; }


    }
}
