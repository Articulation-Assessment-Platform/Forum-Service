using ForumServiceLayer.Models.Enums;

namespace ForumServiceLayer.Models
{
    public class ForumModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<PostModel> Posts { get; set; }
        public Audience Audience { get; set; }
    }
}
