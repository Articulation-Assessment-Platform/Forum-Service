namespace ForumAPI.Models
{
    public class ForumModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Audience { get; set; } = string.Empty;
    }
}
