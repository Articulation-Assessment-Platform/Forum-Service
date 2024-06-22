namespace ForumServiceLayer.Models
{
    public class LikeModel
    {
        public int Id { get; set; }
        public required int PostId { get; set; }
        public int ResponseId { get; set; }
        public required int UserId { get; set; }
    }
}
